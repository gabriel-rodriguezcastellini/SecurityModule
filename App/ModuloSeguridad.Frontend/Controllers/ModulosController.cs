using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ModuloSeguridad.Entities;

namespace ModuloSeguridad.Frontend.Controllers
{
    public class ModulosController : Controller
    {
        private readonly ModuloSeguridadContext _context;

        public ModulosController(ModuloSeguridadContext context)
        {
            _context = context;
        }

        // GET: Modulos
        public async Task<IActionResult> Index()
        {
            var moduloSeguridadContext = _context.Modulos.Include(m => m.ModuloPadre);
            return View(await moduloSeguridadContext.ToListAsync());
        }

        // GET: Modulos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var modulo = await _context.Modulos
                .Include(m => m.ModuloPadre)
                .FirstOrDefaultAsync(m => m.ModuloId == id);
            if (modulo == null)
            {
                return NotFound();
            }
            
            return View(modulo);
        }

        // GET: Modulos/Create
        public IActionResult Create()
        {
            ViewData["ModuloPadreId"] = new SelectList(_context.Modulos, "ModuloId", "Nombre");
            return View();
        }

        // POST: Modulos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ModuloId,Nombre,ModuloPadreId,Eliminado,FechaCreacion,FechaActualizacion,FechaEliminacion,CreadoPor,ActualizadoPor,EliminadoPor")] Modulo modulo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(modulo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ModuloPadreId"] = new SelectList(_context.Modulos, "ModuloId", "Nombre", modulo.ModuloPadreId);
            return View(modulo);
        }

        // GET: Modulos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var modulo = await _context.Modulos.FindAsync(id);
            if (modulo == null)
            {
                return NotFound();
            }
            ViewData["ModuloPadreId"] = new SelectList(_context.Modulos, "ModuloId", "Nombre", modulo.ModuloPadreId);
            return View(modulo);
        }

        // POST: Modulos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ModuloId,Nombre,ModuloPadreId,Eliminado,FechaCreacion,FechaActualizacion,FechaEliminacion,CreadoPor,ActualizadoPor,EliminadoPor")] Modulo modulo)
        {
            if (id != modulo.ModuloId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(modulo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ModuloExists(modulo.ModuloId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["ModuloPadreId"] = new SelectList(_context.Modulos, "ModuloId", "Nombre", modulo.ModuloPadreId);
            return View(modulo);
        }

        // GET: Modulos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var modulo = await _context.Modulos
                .Include(m => m.ModuloPadre)
                .FirstOrDefaultAsync(m => m.ModuloId == id);
            if (modulo == null)
            {
                return NotFound();
            }

            return View(modulo);
        }

        // POST: Modulos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var modulo = await _context.Modulos.FindAsync(id);
            _context.Modulos.Remove(modulo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ModuloExists(int id)
        {
            return _context.Modulos.Any(e => e.ModuloId == id);
        }
    }
}
