﻿using BR_HAXA_FE.WIZARD.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace BR_HAXA_FE.WIZARD.Controllers
{
    public class EstadoesController : Controller
    {
        private readonly BienesRaicesHaxaPrograContext _context;

        public EstadoesController(BienesRaicesHaxaPrograContext context)
        {
            _context = context;
        }

        // GET: Estadoes
        public async Task<IActionResult> Index()
        {
            return View(await _context.Estado.ToListAsync());
        }

        // GET: Estadoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var estado = await _context.Estado
                .FirstOrDefaultAsync(m => m.IdEstado == id);
            if (estado == null)
            {
                return NotFound();
            }

            return View(estado);
        }

        // GET: Estadoes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Estadoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdEstado,Nombre")] Estado estado)
        {
            if (ModelState.IsValid)
            {
                _context.Add(estado);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(estado);
        }

        // GET: Estadoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var estado = await _context.Estado.FindAsync(id);
            if (estado == null)
            {
                return NotFound();
            }
            return View(estado);
        }

        // POST: Estadoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdEstado,Nombre")] Estado estado)
        {
            if (id != estado.IdEstado)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(estado);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EstadoExists(estado.IdEstado))
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
            return View(estado);
        }

        // GET: Estadoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var estado = await _context.Estado
                .FirstOrDefaultAsync(m => m.IdEstado == id);
            if (estado == null)
            {
                return NotFound();
            }

            return View(estado);
        }

        // POST: Estadoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var estado = await _context.Estado.FindAsync(id);
            _context.Estado.Remove(estado);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EstadoExists(int id)
        {
            return _context.Estado.Any(e => e.IdEstado == id);
        }
    }
}
