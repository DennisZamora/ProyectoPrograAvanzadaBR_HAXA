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
    public class ImagenesController : Controller
    {
        private readonly BienesRaicesHaxaPrograContext _context;

        public ImagenesController(BienesRaicesHaxaPrograContext context)
        {
            _context = context;
        }

        // GET: Imagenes
        public async Task<IActionResult> Index()
        {
            var bienesRaicesHaxaPrograContext = _context.Imagenes.Include(i => i.IdPropiedadNavigation);
            return View(await bienesRaicesHaxaPrograContext.ToListAsync());
        }

        // GET: Imagenes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var imagenes = await _context.Imagenes
                .Include(i => i.IdPropiedadNavigation)
                .FirstOrDefaultAsync(m => m.IdImagen == id);
            if (imagenes == null)
            {
                return NotFound();
            }

            return View(imagenes);
        }

        // GET: Imagenes/Create
        public IActionResult Create()
        {
            ViewData["IdPropiedad"] = new SelectList(_context.Propiedad, "IdPropiedad", "Canton");
            return View();
        }

        // POST: Imagenes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdImagen,IdPropiedad,Link")] Imagenes imagenes)
        {
            if (ModelState.IsValid)
            {
                _context.Add(imagenes);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdPropiedad"] = new SelectList(_context.Propiedad, "IdPropiedad", "Canton", imagenes.IdPropiedad);
            return View(imagenes);
        }

        // GET: Imagenes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var imagenes = await _context.Imagenes.FindAsync(id);
            if (imagenes == null)
            {
                return NotFound();
            }
            ViewData["IdPropiedad"] = new SelectList(_context.Propiedad, "IdPropiedad", "Canton", imagenes.IdPropiedad);
            return View(imagenes);
        }

        // POST: Imagenes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdImagen,IdPropiedad,Link")] Imagenes imagenes)
        {
            if (id != imagenes.IdImagen)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(imagenes);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ImagenesExists(imagenes.IdImagen))
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
            ViewData["IdPropiedad"] = new SelectList(_context.Propiedad, "IdPropiedad", "Canton", imagenes.IdPropiedad);
            return View(imagenes);
        }

        // GET: Imagenes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var imagenes = await _context.Imagenes
                .Include(i => i.IdPropiedadNavigation)
                .FirstOrDefaultAsync(m => m.IdImagen == id);
            if (imagenes == null)
            {
                return NotFound();
            }

            return View(imagenes);
        }

        // POST: Imagenes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var imagenes = await _context.Imagenes.FindAsync(id);
            _context.Imagenes.Remove(imagenes);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ImagenesExists(int id)
        {
            return _context.Imagenes.Any(e => e.IdImagen == id);
        }
    }
}
