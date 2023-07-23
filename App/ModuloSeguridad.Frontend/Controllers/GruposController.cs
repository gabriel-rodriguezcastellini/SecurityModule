using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ModuloSeguridad.Entities.Model;
using ModuloSeguridad.Frontend.Authorization;
using ModuloSeguridad.Frontend.Models.Grupos;
using ModuloSeguridad.Services;
using ModuloSeguridad.Services.Common;
using Newtonsoft.Json;
using static ModuloSeguridad.Services.Common.Enums;

namespace ModuloSeguridad.Frontend.Controllers
{
    public class GruposController : BaseController
    {
        private readonly GrupoService grupoService;
        private readonly UsuarioService usuarioService;
        private readonly ModuloService moduloService;
        private readonly EstadoGrupoService estadoGrupoService;

        public GruposController(ILogger<GruposController> logger, 
            IAuthorizationService authorizationService, 
            GrupoService grupoService, 
            UsuarioService usuarioService, 
            ModuloService moduloService,
            EstadoGrupoService estadoGrupoService) 
            : base(logger, authorizationService)
        {
            this.grupoService = grupoService;
            this.usuarioService = usuarioService;
            this.moduloService = moduloService;
            this.estadoGrupoService = estadoGrupoService;
        }

        // GET: Grupos
        [AccionModuloAuthorize(null, Constantes.Modulos.Grupos)]
        public async Task<IActionResult> Index(string descripcion, EstadoGrupos estado)
        {
            try
            {
                logger.InicioMetodo(ControllerContext.ActionDescriptor.ActionName);
                logger.LogInformation("estado: " + estado.ToString());
                if (HttpContext.Request.Headers["X-Requested-With"] == "XMLHttpRequest")
                {
                    return PartialView("_IndexGrid", (await grupoService.GetGruposAsync(descripcion, estado))
                        .Select(g => new GrupoIndexViewModel.Grupo() { Codigo = g.Codigo, Descripcion = g.Descripcion, Estado = g.EstadoGrupo.Nombre, GrupoId = g.GrupoId })
                        .AsQueryable());
                }
                return View(new GrupoIndexViewModel());
            }
            catch (Exception e)
            {
                return RetornarError500(e, ControllerContext.ActionDescriptor.ActionName, ControllerContext.ActionDescriptor.ControllerName);
            }
            finally
            {
                grupoService?.Dispose();
                logger.FinMetodo(ControllerContext.ActionDescriptor.ActionName);
            }
        }

        [AccionModuloAuthorize(nameof(Constantes.Acciones.Agregar), nameof(Constantes.Modulos.Grupos))]
        public async Task<IActionResult> Agregar()
        {
            var grupo = new GrupoAgregarViewModel()
            {
                Activo = true
            };
            using(moduloService)
            using (usuarioService)
            {
                grupo.Usuarios = (await usuarioService.GetUsuariosAsync())
                    .Select(u => new GrupoAgregarViewModel.Usuario {NombreUsuario = u.NombreUsuario, Checked = false, 
                        NombreApellido = string.Concat(u.Nombre," ",u.Apellido) }).ToList();
                grupo.Modulos = (await moduloService.ModulosAsync()).Select(m => new GrupoAgregarViewModel.AccionModulos()
                {
                    ModuloId = m.ModuloId,
                    ModuloNombre = m.Nombre,
                    Acciones = m.AccionModulos.Select(am => new GrupoAgregarViewModel.Accion()
                    {
                        AccionId = am.Accion.AccionId,
                        AccionNombre = am.Accion.Nombre
                    }).ToList()
                }).ToList();
            }

            return View(grupo);
        }

        [AccionModuloAuthorize(nameof(Constantes.Acciones.Agregar), nameof(Constantes.Modulos.Grupos))]
        [HttpPost]
        public async Task<IActionResult> Agregar(GrupoAgregarViewModel model)
        {
            try
            {
                logger.InicioMetodo(ControllerContext.ActionDescriptor.ActionName);                
                var grupo = new Grupo()
                {
                    Codigo = model.Codigo,
                    Descripcion = model.Descripcion,
                    EstadoGrupo = await estadoGrupoService.GetEstadoGrupoAsync(model.Activo ? EstadoGrupos.Activo.ToString() : EstadoGrupos.Inactivo.ToString()),
                    GrupoAccionModulos = new List<GrupoAccionModulo>()
                };
                logger.LogInformation("grupo: " + JsonConvert.SerializeObject(grupo));
                foreach (var modulo in model.Modulos.Where(m=>m.Acciones.Any(a=>a.Checked)))
                {                    
                    foreach (var accion in modulo?.Acciones.Where(a=>a.Checked))
                    {
                        logger.LogInformation("accion: " + JsonConvert.SerializeObject(accion));
                        grupo.GrupoAccionModulos.Add(new GrupoAccionModulo()
                        {
                            AccionModulo = await moduloService.GetAccionModuloAsync(accion.AccionId, modulo.ModuloId)
                        });
                    }
                }
                if (!ModelState.IsValid) return View(model);
                if (await grupoService.GrupoExiste(model.Codigo))
                {
                    logger.LogInformation("Grupo existente");
                    CargarNotificacion("Grupo existente");
                    return View(model);
                }
                await usuarioService.AgregarUsuariosGrupo(await grupoService.Agregar(grupo, User.FindFirstValue(ClaimTypes.NameIdentifier)), 
                    model.Usuarios.Where(u=>u.Checked).Select(x=>x.NombreUsuario).ToList(), User.FindFirstValue(ClaimTypes.NameIdentifier));
                CargarNotificacion("Grupo creado");
                return RedirectToAction(nameof(Index));
            }
            catch (Exception e)
            {
                return RetornarError500(e, ControllerContext.ActionDescriptor.ActionName, ControllerContext.ActionDescriptor.ControllerName);
            }
            finally
            {
                logger.FinMetodo(ControllerContext.ActionDescriptor.ActionName);
            }
        }

        [AccionModuloAuthorize(Constantes.Acciones.Eliminar, Constantes.Modulos.Grupos)]
        [HttpPost]
        public async Task<JsonResult> Eliminar(int grupoId)
        {
            var response = new Dictionary<string, string>()
            {
                {"success","false" }
            };
            using (grupoService)
            {
                if(await grupoService.GrupoTieneUsuarios(grupoId))
                {
                    CargarNotificacion("El grupo tiene usuarios, no puede ser eliminado");
                    response["message"] = "El grupo tiene usuarios, no puede ser eliminado";
                    return Json(response);
                }
                await grupoService.Eliminar(grupoId, User.FindFirstValue(ClaimTypes.NameIdentifier));
                CargarNotificacion("Grupo eliminado");
                response["success"] = "true";
                response["message"] = "Grupo eliminado";
                return Json(response);
            }
        }

        [AccionModuloAuthorize(nameof(Constantes.Acciones.Modificar), nameof(Constantes.Modulos.Grupos))]
        public async Task<IActionResult> Modificar(int id)
        {
            try
            {
                logger.InicioMetodo(ControllerContext.ActionDescriptor.ActionName);
                logger.LogInformation("id: " + id);
                var grupo = await grupoService.GetGrupoAsync(id);
                logger.LogInformation("Se va a editar el grupo {0}", grupo.Codigo);
                if (grupo == null)
                {
                    logger.LogInformation("El grupo no existe");
                    CargarNotificacion("El grupo no existe");
                    return RedirectToAction(nameof(Index));
                }
                var grupoModificar = new GrupoModificarViewModel()
                {
                    GrupoId = grupo.GrupoId,
                    Codigo = grupo.Codigo,
                    Descripcion = grupo.Descripcion,
                    Activo = grupo.EstadoGrupo.Nombre == EstadoGrupos.Activo.ToString(),
                    Usuarios = (await usuarioService.GetUsuariosAsync())
                        .Select(u => new GrupoModificarViewModel.Usuario
                        {
                            NombreUsuario = u.NombreUsuario,
                            Checked = u.UsuarioGrupos.Any(gu => gu.GrupoId == id),
                            NombreApellido = string.Concat(u.Nombre, " ", u.Apellido)
                        }).ToList(),
                    Modulos = (await moduloService.ModulosAsync()).Select(m => new GrupoModificarViewModel.AccionModulos()
                    {
                        ModuloId = m.ModuloId,
                        ModuloNombre = m.Nombre,
                        Checked = m.AccionModulos.Any(am => am.GrupoAccionModulos.Any(gam => gam.GrupoId == id)),
                        Acciones = m.AccionModulos.Select(am => new GrupoModificarViewModel.Accion()
                        {
                            AccionId = am.Accion.AccionId,
                            AccionNombre = am.Accion.Nombre,
                            Checked = am.GrupoAccionModulos.Any(gam => gam.GrupoId == id)
                        }).ToList()
                    }).ToList()
                };
                return View(grupoModificar);
            }
            catch (Exception e)
            {
                return RetornarError500(e, ControllerContext.ActionDescriptor.ActionName, ControllerContext.ActionDescriptor.ControllerName);
            }
            finally
            {
                usuarioService?.Dispose();
                moduloService?.Dispose();
                logger.FinMetodo(ControllerContext.ActionDescriptor.ActionName);
            }
        }

        [HttpPost]
        [AccionModuloAuthorize(nameof(Constantes.Acciones.Modificar), nameof(Constantes.Modulos.Grupos))]
        public async Task<IActionResult> Modificar(GrupoModificarViewModel model)
        {
            try
            {
                logger.InicioMetodo(ControllerContext.ActionDescriptor.ActionName);                
                logger.LogInformation("Usuario que realiza la acción: {0}", User.FindFirstValue(ClaimTypes.NameIdentifier));
                var grupo = await grupoService.GetGrupoAsync(model.GrupoId);
                grupo.Codigo = model.Codigo;
                grupo.Descripcion = model.Descripcion;
                grupo.EstadoGrupo = await estadoGrupoService.GetEstadoGrupoAsync(model.Activo ? EstadoGrupos.Activo.ToString() : EstadoGrupos.Inactivo.ToString());
                grupo.GrupoAccionModulos = new List<GrupoAccionModulo>();                
                foreach (var modulo in model.Modulos.Where(m => m.Acciones.Any(a=>a.Checked)))
                {                    
                    foreach (var accion in modulo?.Acciones.Where(a => a.Checked))
                    {
                        logger.LogInformation("accion: " + JsonConvert.SerializeObject(accion));
                        grupo.GrupoAccionModulos.Add(new GrupoAccionModulo()
                        {
                            AccionModulo = await moduloService.GetAccionModuloAsync(accion.AccionId, modulo.ModuloId)
                        });
                    }
                }
                if (!ModelState.IsValid) return View(model);
                if (await grupoService.GrupoExiste(model.Codigo) && model.Codigo != grupo.Codigo)
                {
                    logger.LogInformation("Debe elegir otro código para el grupo, el mismo ya existe");
                    CargarNotificacion("Debe elegir otro código para el grupo, el mismo ya existe");
                    return View(model);
                }
                await grupoService.Modificar(grupo, User.FindFirstValue(ClaimTypes.NameIdentifier));
                await usuarioService.AgregarUsuariosGrupo(model.GrupoId, model.Usuarios.Where(u => u.Checked).Select(x => x.NombreUsuario).ToList(), User.FindFirstValue(ClaimTypes.NameIdentifier));
                CargarNotificacion("Grupo actualizado");
                return RedirectToAction(nameof(Index));
            }
            catch (Exception e)
            {
                return RetornarError500(e, ControllerContext.ActionDescriptor.ActionName, ControllerContext.ActionDescriptor.ControllerName);
            }
            finally
            {
                estadoGrupoService?.Dispose();
                logger.FinMetodo(ControllerContext.ActionDescriptor.ActionName);
            }
        }
    }
}
