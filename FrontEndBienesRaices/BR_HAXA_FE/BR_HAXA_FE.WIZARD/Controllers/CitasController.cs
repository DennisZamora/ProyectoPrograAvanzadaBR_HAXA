using BR_HAXA_FE.WIZARD.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace BR_HAXA_FE.WIZARD.Controllers
{
    public class CitasController : Controller
    {
        private readonly BienesRaicesHaxaPrograContext _context;

        public CitasController(BienesRaicesHaxaPrograContext context)
        {
            _context = context;
        }

        // GET: Citas
        public async Task<IActionResult> Index()
        {
            var bienesRaicesHaxaPrograContext = _context.Cita.Include(c => c.IdPropiedadNavigation).Include(c => c.IdUsuarioNavigation);
            return View(await bienesRaicesHaxaPrograContext.ToListAsync());
        }

        // GET: Citas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cita = await _context.Cita
                .Include(c => c.IdPropiedadNavigation)
                .Include(c => c.IdUsuarioNavigation)
                .FirstOrDefaultAsync(m => m.IdCita == id);
            if (cita == null)
            {
                return NotFound();
            }

            return View(cita);
        }

        // GET: Citas/Create
        public IActionResult Create()
        {
            ViewData["IdPropiedad"] = new SelectList(_context.Propiedad, "IdPropiedad", "Canton");
            ViewData["IdUsuario"] = new SelectList(_context.Usuario, "IdUsuario", "Apellido1");
            return View();
        }

        // POST: Citas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdCita,IdUsuario,IdPropiedad,FechaInicio,FechaFinal")] Cita cita)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cita);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdPropiedad"] = new SelectList(_context.Propiedad, "IdPropiedad", "Canton", cita.IdPropiedad);
            ViewData["IdUsuario"] = new SelectList(_context.Usuario, "IdUsuario", "Apellido1", cita.IdUsuario);
            return View(cita);
        }

        // GET: Citas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cita = await _context.Cita.FindAsync(id);
            if (cita == null)
            {
                return NotFound();
            }
            ViewData["IdPropiedad"] = new SelectList(_context.Propiedad, "IdPropiedad", "Canton", cita.IdPropiedad);
            ViewData["IdUsuario"] = new SelectList(_context.Usuario, "IdUsuario", "Apellido1", cita.IdUsuario);
            return View(cita);
        }

        // POST: Citas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdCita,IdUsuario,IdPropiedad,FechaInicio,FechaFinal")] Cita cita)
        {
            if (id != cita.IdCita)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cita);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CitaExists(cita.IdCita))
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
            ViewData["IdPropiedad"] = new SelectList(_context.Propiedad, "IdPropiedad", "Canton", cita.IdPropiedad);
            ViewData["IdUsuario"] = new SelectList(_context.Usuario, "IdUsuario", "Apellido1", cita.IdUsuario);
            return View(cita);
        }

        // GET: Citas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cita = await _context.Cita
                .Include(c => c.IdPropiedadNavigation)
                .Include(c => c.IdUsuarioNavigation)
                .FirstOrDefaultAsync(m => m.IdCita == id);
            if (cita == null)
            {
                return NotFound();
            }

            return View(cita);
        }

        // POST: Citas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cita = await _context.Cita.FindAsync(id);
            _context.Cita.Remove(cita);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CitaExists(int id)
        {
            return _context.Cita.Any(e => e.IdCita == id);
        }
    }
}
