using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BR_HAXA_FE.WIZARD.Models;

namespace BR_HAXA_FE.WIZARD.Controllers
{
    public class PropiedadsController : Controller
    {
        private readonly BienesRaicesHaxaPrograContext _context;

        public PropiedadsController(BienesRaicesHaxaPrograContext context)
        {
            _context = context;
        }

        // GET: Propiedads
        public async Task<IActionResult> Index()
        {
            var bienesRaicesHaxaPrograContext = _context.Propiedad.Include(p => p.IdCategoriaNavigation).Include(p => p.IdEstadoNavigation).Include(p => p.IdUsuarioNavigation);
            return View(await bienesRaicesHaxaPrograContext.ToListAsync());
        }

        // GET: Propiedads/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var propiedad = await _context.Propiedad
                .Include(p => p.IdCategoriaNavigation)
                .Include(p => p.IdEstadoNavigation)
                .Include(p => p.IdUsuarioNavigation)
                .FirstOrDefaultAsync(m => m.IdPropiedad == id);
            if (propiedad == null)
            {
                return NotFound();
            }

            return View(propiedad);
        }

        // GET: Propiedads/Create
        public IActionResult Create()
        {
            ViewData["IdCategoria"] = new SelectList(_context.Categoria, "IdCategoria", "Nombre");
            ViewData["IdEstado"] = new SelectList(_context.Estado, "IdEstado", "Nombre");
            ViewData["IdUsuario"] = new SelectList(_context.Usuario, "IdUsuario", "Apellido1");
            return View();
        }

        // POST: Propiedads/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdPropiedad,Nombre,Provincia,Canton,Distrito,Direccion,Descripcion,IdCategoria,IdEstado,Pisos,M2,Habitacion,Baños,Garage,IdUsuario,Precio")] Propiedad propiedad)
        {
            if (ModelState.IsValid)
            {
                _context.Add(propiedad);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdCategoria"] = new SelectList(_context.Categoria, "IdCategoria", "Nombre", propiedad.IdCategoria);
            ViewData["IdEstado"] = new SelectList(_context.Estado, "IdEstado", "Nombre", propiedad.IdEstado);
            ViewData["IdUsuario"] = new SelectList(_context.Usuario, "IdUsuario", "Apellido1", propiedad.IdUsuario);
            return View(propiedad);
        }

        // GET: Propiedads/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var propiedad = await _context.Propiedad.FindAsync(id);
            if (propiedad == null)
            {
                return NotFound();
            }
            ViewData["IdCategoria"] = new SelectList(_context.Categoria, "IdCategoria", "Nombre", propiedad.IdCategoria);
            ViewData["IdEstado"] = new SelectList(_context.Estado, "IdEstado", "Nombre", propiedad.IdEstado);
            ViewData["IdUsuario"] = new SelectList(_context.Usuario, "IdUsuario", "Apellido1", propiedad.IdUsuario);
            return View(propiedad);
        }

        // POST: Propiedads/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdPropiedad,Nombre,Provincia,Canton,Distrito,Direccion,Descripcion,IdCategoria,IdEstado,Pisos,M2,Habitacion,Baños,Garage,IdUsuario,Precio")] Propiedad propiedad)
        {
            if (id != propiedad.IdPropiedad)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(propiedad);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PropiedadExists(propiedad.IdPropiedad))
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
            ViewData["IdCategoria"] = new SelectList(_context.Categoria, "IdCategoria", "Nombre", propiedad.IdCategoria);
            ViewData["IdEstado"] = new SelectList(_context.Estado, "IdEstado", "Nombre", propiedad.IdEstado);
            ViewData["IdUsuario"] = new SelectList(_context.Usuario, "IdUsuario", "Apellido1", propiedad.IdUsuario);
            return View(propiedad);
        }

        // GET: Propiedads/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var propiedad = await _context.Propiedad
                .Include(p => p.IdCategoriaNavigation)
                .Include(p => p.IdEstadoNavigation)
                .Include(p => p.IdUsuarioNavigation)
                .FirstOrDefaultAsync(m => m.IdPropiedad == id);
            if (propiedad == null)
            {
                return NotFound();
            }

            return View(propiedad);
        }

        // POST: Propiedads/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var propiedad = await _context.Propiedad.FindAsync(id);
            _context.Propiedad.Remove(propiedad);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PropiedadExists(int id)
        {
            return _context.Propiedad.Any(e => e.IdPropiedad == id);
        }
    }
}
