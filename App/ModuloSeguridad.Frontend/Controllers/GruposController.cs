using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ModuloSeguridad.Entities;
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
                logger.LogInformation("descripcion: " + descripcion);
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
            var grupo = new AgregarGrupoViewModel()
            {
                Activo = true
            };
            using(moduloService)
            using (usuarioService)
            {
                grupo.Usuarios = (await usuarioService.GetUsuariosAsync())
                    .Select(u => new AgregarGrupoViewModel.Usuario {NombreUsuario = u.NombreUsuario, Checked = false, 
                        NombreApellido = string.Concat(u.Nombre," ",u.Apellido) }).ToList();
                grupo.Modulos = (await moduloService.ModulosAsync()).Select(m => new AgregarGrupoViewModel.AccionModulos()
                {
                    ModuloId = m.ModuloId,
                    ModuloNombre = m.Nombre,
                    Acciones = m.AccionModulos.Select(am => new AgregarGrupoViewModel.Accion()
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
        public async Task<IActionResult> Agregar(AgregarGrupoViewModel model)
        {
            try
            {
                logger.InicioMetodo(ControllerContext.ActionDescriptor.ActionName);
                logger.LogInformation("model: " + JsonConvert.SerializeObject(model));
                var grupo = new Grupo()
                {
                    Codigo = model.Codigo,
                    Descripcion = model.Descripcion,
                    EstadoGrupo = await estadoGrupoService.GetEstadoGrupoAsync(model.Activo ? EstadoGrupos.Activo.ToString() : EstadoGrupos.Inactivo.ToString()),
                    GrupoAccionModulos = new List<GrupoAccionModulo>()
                };
                logger.LogInformation("grupo: " + JsonConvert.SerializeObject(grupo));
                foreach (var modulo in model.Modulos.Where(m=>m.Checked))
                {
                    logger.LogInformation("modulo: " + JsonConvert.SerializeObject(modulo));
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
                await grupoService.Agregar(grupo, User.FindFirstValue(ClaimTypes.NameIdentifier));
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

        // GET: Grupos/Details/5
        //public async Task<IActionResult> Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var grupo = await _context.Grupos
        //        .Include(g => g.EstadoGrupo)
        //        .FirstOrDefaultAsync(m => m.GrupoId == id);
        //    if (grupo == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(grupo);
        //}

        //// GET: Grupos/Create
        //public IActionResult Create()
        //{
        //    ViewData["EstadoGrupoId"] = new SelectList(_context.EstadoGrupos, "EstadoGrupoId", "Nombre");
        //    return View();
        //}

        //// POST: Grupos/Create
        //// To protect from overposting attacks, enable the specific properties you want to bind to.
        //// For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create([Bind("GrupoId,Codigo,EstadoGrupoId,FechaCreacion,FechaActualizacion,CreadoPor,ActualizadoPor")] Grupo grupo)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _context.Add(grupo);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }
        //    ViewData["EstadoGrupoId"] = new SelectList(_context.EstadoGrupos, "EstadoGrupoId", "Nombre", grupo.EstadoGrupoId);
        //    return View(grupo);
        //}

        //// GET: Grupos/Edit/5
        //public async Task<IActionResult> Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var grupo = await _context.Grupos.FindAsync(id);
        //    if (grupo == null)
        //    {
        //        return NotFound();
        //    }
        //    ViewData["EstadoGrupoId"] = new SelectList(_context.EstadoGrupos, "EstadoGrupoId", "Nombre", grupo.EstadoGrupoId);
        //    return View(grupo);
        //}

        //// POST: Grupos/Edit/5
        //// To protect from overposting attacks, enable the specific properties you want to bind to.
        //// For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(int id, [Bind("GrupoId,Codigo,EstadoGrupoId,FechaCreacion,FechaActualizacion,CreadoPor,ActualizadoPor")] Grupo grupo)
        //{
        //    if (id != grupo.GrupoId)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            _context.Update(grupo);
        //            await _context.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!GrupoExists(grupo.GrupoId))
        //            {
        //                return NotFound();
        //            }
        //            else
        //            {
        //                throw;
        //            }
        //        }
        //        return RedirectToAction(nameof(Index));
        //    }
        //    ViewData["EstadoGrupoId"] = new SelectList(_context.EstadoGrupos, "EstadoGrupoId", "Nombre", grupo.EstadoGrupoId);
        //    return View(grupo);
        //}

        //// GET: Grupos/Delete/5
        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var grupo = await _context.Grupos
        //        .Include(g => g.EstadoGrupo)
        //        .FirstOrDefaultAsync(m => m.GrupoId == id);
        //    if (grupo == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(grupo);
        //}

        //// POST: Grupos/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    var grupo = await _context.Grupos.FindAsync(id);
        //    _context.Grupos.Remove(grupo);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        //private bool GrupoExists(int id)
        //{
        //    return _context.Grupos.Any(e => e.GrupoId == id);
        //}
    }
}
