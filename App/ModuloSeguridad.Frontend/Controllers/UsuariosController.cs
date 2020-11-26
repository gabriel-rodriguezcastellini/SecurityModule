using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ModuloSeguridad.Entities;
using ModuloSeguridad.Services;

namespace ModuloSeguridad.Frontend.Controllers
{
    public class UsuariosController : BaseController
    {
        private readonly UsuarioService usuarioService;
        public UsuariosController(ModuloSeguridadContext context, ILogger<UsuariosController> logger, UsuarioService usuarioService) : base(logger, context)
        {
            this.usuarioService = usuarioService;
        }

        // GET: Usuarios
        public IActionResult Login()
        {
            return View(new Usuario());
        }

        //// GET: Usuarios/Details/5
        //public async Task<IActionResult> Details(string id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var usuario = await _context.Usuarios
        //        .Include(u => u.EstadoUsuario)
        //        .FirstOrDefaultAsync(m => m.NombreUsuario == id);
        //    if (usuario == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(usuario);
        //}

        //// GET: Usuarios/Create
        //public IActionResult Create()
        //{
        //    ViewData["EstadoUsuarioId"] = new SelectList(_context.EstadoUsuarios, "EstadoUsuarioId", "Nombre");
        //    return View();
        //}

        //// POST: Usuarios/Create
        //// To protect from overposting attacks, enable the specific properties you want to bind to.
        //// For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create([Bind("NombreUsuario,Nombre,Apellido,Clave,Mail,EstadoUsuarioId,Eliminado,FechaCreacion,FechaActualizacion,FechaEliminacion,CreadoPor,ActualizadoPor,EliminadoPor")] Usuario usuario)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _context.Add(usuario);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }
        //    ViewData["EstadoUsuarioId"] = new SelectList(_context.EstadoUsuarios, "EstadoUsuarioId", "Nombre", usuario.EstadoUsuarioId);
        //    return View(usuario);
        //}

        //// GET: Usuarios/Edit/5
        //public async Task<IActionResult> Edit(string id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var usuario = await _context.Usuarios.FindAsync(id);
        //    if (usuario == null)
        //    {
        //        return NotFound();
        //    }
        //    ViewData["EstadoUsuarioId"] = new SelectList(_context.EstadoUsuarios, "EstadoUsuarioId", "Nombre", usuario.EstadoUsuarioId);
        //    return View(usuario);
        //}

        //// POST: Usuarios/Edit/5
        //// To protect from overposting attacks, enable the specific properties you want to bind to.
        //// For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(string id, [Bind("NombreUsuario,Nombre,Apellido,Clave,Mail,EstadoUsuarioId,Eliminado,FechaCreacion,FechaActualizacion,FechaEliminacion,CreadoPor,ActualizadoPor,EliminadoPor")] Usuario usuario)
        //{
        //    if (id != usuario.NombreUsuario)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            _context.Update(usuario);
        //            await _context.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!UsuarioExists(usuario.NombreUsuario))
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
        //    ViewData["EstadoUsuarioId"] = new SelectList(_context.EstadoUsuarios, "EstadoUsuarioId", "Nombre", usuario.EstadoUsuarioId);
        //    return View(usuario);
        //}

        //// GET: Usuarios/Delete/5
        //public async Task<IActionResult> Delete(string id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var usuario = await _context.Usuarios
        //        .Include(u => u.EstadoUsuario)
        //        .FirstOrDefaultAsync(m => m.NombreUsuario == id);
        //    if (usuario == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(usuario);
        //}

        //// POST: Usuarios/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(string id)
        //{
        //    var usuario = await _context.Usuarios.FindAsync(id);
        //    _context.Usuarios.Remove(usuario);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        //private bool UsuarioExists(string id)
        //{
        //    return _context.Usuarios.Any(e => e.NombreUsuario == id);
        //}
    }
}
