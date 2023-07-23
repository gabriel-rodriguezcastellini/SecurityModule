using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using ModuloSeguridad.Entities.Model;
using ModuloSeguridad.Frontend.Authorization;
using ModuloSeguridad.Frontend.Extensions;
using ModuloSeguridad.Frontend.Models;
using ModuloSeguridad.Frontend.Models.Usuarios;
using ModuloSeguridad.Services;
using ModuloSeguridad.Services.Common;
using ModuloSeguridad.Services.Extensions.Mail;
using Newtonsoft.Json;
using static ModuloSeguridad.Services.Common.Enums;

namespace ModuloSeguridad.Frontend.Controllers
{
    public class UsuariosController : BaseController
    {
        private readonly UsuarioService usuarioService;
        private readonly GrupoService grupoService;
        private readonly EstadoUsuarioService estadoUsuarioService;
        private readonly MailSender mailSender;

        public UsuariosController(ILogger<UsuariosController> logger, 
            IAuthorizationService authorizationService, 
            UsuarioService usuarioService,
            GrupoService grupoService, 
            EstadoUsuarioService estadoUsuarioService,
            MailSender mailSender) : base(logger, authorizationService)
        {
            this.usuarioService = usuarioService;
            this.grupoService = grupoService;
            this.estadoUsuarioService = estadoUsuarioService;
            this.mailSender = mailSender;
        }
        
        [AllowAnonymous]
        public IActionResult AccesoDenegado()
        {
            return View();
        }

        [AllowAnonymous]
        public async Task<IActionResult> Login(string returnUrl = null)
        {
            if (User?.Identity?.IsAuthenticated == true) return RedirectToAction(nameof(HomeController.Index), "Home");
            await HttpContext.SignOutAsync(
                CookieAuthenticationDefaults.AuthenticationScheme);
            ReturnUrl = returnUrl;
            return View(new UsuarioLoginViewModel());
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Login(UsuarioLoginViewModel model, string returnUrl = null)
        {
            try
            {
                logger.InicioMetodo(ControllerContext.ActionDescriptor.ActionName);
                logger.LogInformation("Usuario: " + model.NombreUsuario);
                Usuario usuario;
                List<Claim> claims;
                ClaimsIdentity claimsIdentity;
                var accionModulos = new List<UsuarioViewModel.AccionModulo>();
                ReturnUrl = returnUrl;
                if (!ModelState.IsValid) return View(model);
                usuario = await usuarioService.GetUsuarioAsync(model.NombreUsuario, model.Clave);
                logger.LogInformation("usuario " + (usuario == null ? "no encontrado" : usuario.NombreUsuario + "encontrado"));
                if (usuario == null)
                {
                    CargarNotificacion("Usuario inexistente");
                    return View(model);
                }
                AccionModuloHelper.GuardarModulos(usuario.UsuarioGrupos, ref accionModulos); //carga las acciones/modulos para luego guardarlas en los claims
                claims = new List<Claim>
                {
                    new Claim(ClaimTypes.NameIdentifier, usuario.NombreUsuario),
                    new Claim(ClaimTypes.Name, usuario.Nombre),
                    new Claim(ClaimTypes.Surname, usuario.Apellido),
                    new Claim(ClaimTypes.Email, usuario.Mail),
                    new Claim(ClaimTypes.UserData, JsonConvert.SerializeObject(accionModulos))
                };
                claimsIdentity = new ClaimsIdentity(
                    claims, CookieAuthenticationDefaults.AuthenticationScheme);
                await HttpContext.SignInAsync(
                    CookieAuthenticationDefaults.AuthenticationScheme,
                    new ClaimsPrincipal(claimsIdentity));
                logger.LogInformation("Usuario {usuario} inició sesión a las {tiempo}.",
                    usuario.NombreUsuario, DateTime.UtcNow);
                CargarNotificacion("Inicio de sesión exitoso");
                return LocalRedirect(Url.GetLocalUrl(returnUrl));
            }
            catch (Exception e)
            {
                return RetornarError500(e, ControllerContext?.ActionDescriptor?.ActionName, ControllerContext?.ActionDescriptor?.ControllerName);
            }
            finally
            {
                logger.FinMetodo(ControllerContext.ActionDescriptor.ActionName);
                usuarioService?.Dispose();
            }
        }

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            logger.LogInformation("Usuario {Name} cerró sesión a las {Time}.",
                User.FindFirstValue(ClaimTypes.NameIdentifier), DateTime.UtcNow);
            
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

            return RedirectToAction(nameof(Login));
        }

        [AllowAnonymous]        
        public IActionResult RecuperarClave()
        {
            if (User?.Identity?.IsAuthenticated == true) return RedirectToAction(nameof(HomeController.Index), "Home");
            return View(new UsuarioRecuperarClaveViewModel());
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> RecuperarClave(UsuarioRecuperarClaveViewModel model)
        {
            if (User?.Identity?.IsAuthenticated == true) return RedirectToAction(nameof(HomeController.Index), "Home");
            logger.LogInformation("Tratando de recuperar clave para {0}", JsonConvert.SerializeObject(model));
            using (usuarioService)
            {
                if(!await usuarioService.UsuarioExiste(model.Usuario, model.Mail))
                {
                    logger.LogInformation("El usuario no existe");
                    CargarNotificacion("Usuario incorrecto");
                    return View(model);
                }
                await usuarioService.ResetearClave(model.Usuario, "Recuperación de clave", false);
                CargarNotificacion("Se ha enviado un mail con la nueva clave");
                return RedirectToAction(nameof(Login));
            }
        }

        public IActionResult CambiarClave()
        {
            return View(new UsuarioCambiarClaveViewModel());
        }

        [HttpPost]
        public async Task<IActionResult> CambiarClave(UsuarioCambiarClaveViewModel model)
        {
            try
            {
                logger.InicioMetodo(ControllerContext.ActionDescriptor.ActionName);
                var nombreUsuario = User?.FindFirstValue(ClaimTypes.NameIdentifier);
                logger.LogInformation("El usuario {0} va a cambiar su clave", nombreUsuario);
                if (!ModelState.IsValid) return View(model);
                using (usuarioService)
                {
                    if (!await usuarioService.EsContraseniaCorrecta(nombreUsuario, model.ClaveActual))
                    {
                        logger.LogInformation("La clave ingresada no es correcta");
                        CargarNotificacion("La clave ingresada no es correcta");
                        return View(model);
                    }
                    await usuarioService.ResetearClave(User?.FindFirstValue(ClaimTypes.NameIdentifier), "Nueva clave", false, model.ClaveNueva);
                    CargarNotificacion("Clave cambiada");
                    return RedirectToAction(nameof(HomeController.Index), "Home");
                }
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

        // GET: Usuarios
        [AccionModuloAuthorize(null, Constantes.Modulos.Usuarios)]
        public async Task<IActionResult> Index(string apellidoNombre, int? grupoId, EstadoUsuarios estado)
        {
            try
            {
                logger.InicioMetodo(ControllerContext?.ActionDescriptor?.ActionName);
                logger.LogInformation("apellidoNombre: " + apellidoNombre);
                logger.LogInformation("grupoId: " + grupoId);
                logger.LogInformation("estado: " + estado.ToString());                
                var usuarioIndexViewModel = new UsuarioIndexViewModel()
                {
                    Grupos = new List<SelectListItem>()
                    {
                        new SelectListItem()
                        {
                            Value = null,
                            Text = "TODOS"
                        }
                    }
                };
                usuarioIndexViewModel.Grupos.AddRange((await grupoService.GetGruposAsync())
                    .Select(g => new SelectListItem() { Value = g.GrupoId.ToString(), Text = g.Codigo }));
                if (HttpContext.Request.Headers["X-Requested-With"] == "XMLHttpRequest") 
                {
                    return PartialView("_IndexGrid", 
                        (await usuarioService.GetUsuariosAsync(User.FindFirstValue(ClaimTypes.NameIdentifier), apellidoNombre, grupoId, estado))
                        .Select(u=>new UsuarioIndexViewModel.Usuario() { NombreUsuario = u.NombreUsuario, ApellidoNombre = string.Concat(u.Apellido, " ", u.Nombre),
                            Grupos = string.Join(", ", u.UsuarioGrupos.Select(ug => ug.Grupo.Codigo)), Email = u.Mail, Estado = u.EstadoUsuario.Nombre
                        }).AsQueryable());
                }
                return View(usuarioIndexViewModel);
            }
            catch (Exception e)
            {
                return RetornarError500(e, ControllerContext?.ActionDescriptor?.ActionName, ControllerContext?.ActionDescriptor?.ControllerName);
            }
            finally
            {
                usuarioService?.Dispose();
                grupoService?.Dispose();
                logger.FinMetodo(ControllerContext?.ActionDescriptor?.ActionName);
            }
        }

        [AccionModuloAuthorize(nameof(Constantes.Acciones.Agregar), nameof(Constantes.Modulos.Usuarios))]
        public async Task<IActionResult> Agregar()
        {
            var usuario = new UsuarioAgregarViewModel()
            {
                Activo = true
            };
            using (grupoService)
            {
                usuario.Grupos = (await grupoService.GetGruposAsync())
                    .Select(g => new UsuarioAgregarViewModel.Grupo() { Nombre = g.Codigo, GrupoId = g.GrupoId, Checked = false }).ToList();
            }
            return View(usuario);
        }

        [AccionModuloAuthorize(nameof(Constantes.Acciones.Agregar), nameof(Constantes.Modulos.Usuarios))]
        [HttpPost]
        public async Task<IActionResult> Agregar(UsuarioAgregarViewModel model)
        {
            try
            {
                logger.InicioMetodo(ControllerContext.ActionDescriptor.ActionName);
                logger.LogInformation("model: " + JsonConvert.SerializeObject(model));
                var usuario = new Usuario()
                {
                    NombreUsuario = model.NombreUsuario,
                    Apellido = model.Apellido,
                    Nombre = model.Nombre,
                    Mail = model.Mail,
                    EstadoUsuario = await estadoUsuarioService.GetEstadoUsuarioAsync(model.Activo ? EstadoUsuarios.Activo.ToString() : EstadoUsuarios.Inactivo.ToString()),
                    UsuarioGrupos = model.Grupos.Where(g => g.Checked).Select(g => new UsuarioGrupo() { NombreUsuario = model.NombreUsuario, GrupoId = g.GrupoId }).ToList()
                };
                if (!ModelState.IsValid) return View(model);
                if (await usuarioService.UsuarioExiste(model.NombreUsuario))
                {
                    logger.LogInformation("Usuario existente");
                    CargarNotificacion("Usuario existente");                    
                    return View(model);
                }
                await usuarioService.Agregar(usuario);
                CargarNotificacion("Usuario creado");
                return RedirectToAction(nameof(Index));
            }
            catch (Exception e)
            {
                return RetornarError500(e, ControllerContext.ActionDescriptor.ActionName, ControllerContext.ActionDescriptor.ControllerName);
            }
            finally
            {
                usuarioService?.Dispose();
                estadoUsuarioService?.Dispose();
                logger.FinMetodo(ControllerContext.ActionDescriptor.ActionName);
            }
        }

        [AccionModuloAuthorize(Constantes.Acciones.Eliminar, Constantes.Modulos.Usuarios)]
        [HttpPost]
        public async Task<JsonResult> Eliminar(string nombreUsuario)
        {
            using (usuarioService)
            {
                if (await usuarioService.Eliminar(nombreUsuario))
                {
                    CargarNotificacion(string.Format("Usuario {0} eliminado", nombreUsuario));
                    return Json(nombreUsuario);
                }
                else
                {
                    Response.StatusCode = (int)HttpStatusCode.BadRequest;
                    return Json(null);
                }
            }
        }        

        [AccionModuloAuthorize(Constantes.Acciones.Modificar, Constantes.Modulos.Usuarios)]
        public async Task<IActionResult> Modificar(string id)
        {
            try
            {
                logger.InicioMetodo(ControllerContext.ActionDescriptor.ActionName);
                logger.LogInformation("id: " + id);
                UsuarioModificarViewModel model;
                Usuario usuario;
                var grupos = await grupoService.GetGruposAsync();
                usuario = await usuarioService.GetUsuarioAsync(id);
                if(usuario == null)
                {
                    logger.LogInformation("Usuario inexistente");
                    CargarNotificacion("Usuario inexistente");
                    return RedirectToAction(nameof(Index));
                }
                model = new UsuarioModificarViewModel()
                {
                    NombreUsuario = usuario.NombreUsuario,
                    Apellido = usuario.Apellido,
                    Nombre = usuario.Nombre,
                    Mail = usuario.Mail,
                    Activo = usuario.EstadoUsuario.Nombre == EstadoUsuarios.Activo.ToString(),
                    Grupos = grupos.ToList().Select(g=>new UsuarioModificarViewModel.Grupo() { Checked = usuario.UsuarioGrupos?
                                    .Any(ug => ug.GrupoId == g.GrupoId) == true, GrupoId = g.GrupoId, Nombre = g.Codigo }).ToList()
                };
                return View(model);
            }
            catch (Exception e)
            {
                return RetornarError500(e, ControllerContext.ActionDescriptor.ActionName, ControllerContext.ActionDescriptor.ControllerName);
            }
            finally
            {
                usuarioService?.Dispose();
                grupoService?.Dispose();
                logger.FinMetodo(ControllerContext.ActionDescriptor.ActionName);
            }            
        }

        [HttpPost]
        [AccionModuloAuthorize(Constantes.Acciones.Modificar, Constantes.Modulos.Usuarios)]
        public async Task<IActionResult> Modificar(UsuarioModificarViewModel model)
        {
            try
            {
                logger.InicioMetodo(ControllerContext.ActionDescriptor.ActionName);
                logger.LogInformation("model: " + JsonConvert.SerializeObject(model));
                var usuario = await usuarioService.GetUsuarioAsync(model.NombreUsuario);
                usuario.Apellido = model.Apellido;
                usuario.Nombre = model.Nombre;
                usuario.Mail = model.Mail;
                usuario.EstadoUsuario = await estadoUsuarioService.GetEstadoUsuarioAsync(model.Activo ? EstadoUsuarios.Activo.ToString() : EstadoUsuarios.Inactivo.ToString());
                usuario.UsuarioGrupos = model.Grupos.Where(g => g.Checked).Select(g => new UsuarioGrupo() { NombreUsuario = model.NombreUsuario, GrupoId = g.GrupoId }).ToList();
                if (!ModelState.IsValid) return View(model);
                await usuarioService.Modificar(usuario);
                CargarNotificacion("Usuario modificado");
                return RedirectToAction(nameof(Index));
            }
            catch (Exception e)
            {
                return RetornarError500(e, ControllerContext.ActionDescriptor.ActionName, ControllerContext.ActionDescriptor.ControllerName);
            }
            finally
            {
                usuarioService?.Dispose();
                estadoUsuarioService?.Dispose();
                logger.FinMetodo(ControllerContext.ActionDescriptor.ActionName);
            }
        }

        [HttpPost]
        [AccionModuloAuthorize(Constantes.Acciones.ResetearClave, Constantes.Modulos.Usuarios)]
        public async Task<JsonResult> ResetearClave(string nombreUsuario)
        {
            using (usuarioService)
            {
                await usuarioService.ResetearClave(nombreUsuario, "Nueva clave", false);
                CargarNotificacion(string.Format("Se reseteó la clave del usuario {0}", nombreUsuario));
                return Json(nombreUsuario);
            }
        }
    }
}
