using BR_HAXA_FE.Models;
using BR_HAXA_FE.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Threading.Tasks;

namespace BR_HAXA_FE.Controllers
{
    public class CitasController : Controller
    {
        private readonly ICitaServices citaServices;
        private readonly IUsuarioServices usuarioServices;
        private readonly IPropiedadServices propiedadServices;

        public CitasController(ICitaServices citaServices, IUsuarioServices usuarioServices, IPropiedadServices propiedadServices)
        {
            this.citaServices = citaServices;
            this.usuarioServices = usuarioServices;
            this.propiedadServices = propiedadServices;
        }

        //public IActionResult Index()
        //{
        //    return View();
        //}

        // GET: Citas
        public async Task<IActionResult> Index()
        {
            //var bienesRaicesHaxaPrograContext = _context.Cita.Include(c => c.IdPropiedadNavigation).Include(c => c.IdUsuarioNavigation);
            return View(await citaServices.GetAllAsync());
        }

        // GET: Citas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cita = await citaServices.GetOneByIdAsync((int)id);
            if (cita == null)
            {
                return NotFound();
            }

            return View(cita);
        }

        // GET: Citas/Create
        public IActionResult Create()
        {
            ViewData["IdPropiedad"] = new SelectList(propiedadServices.GetAll(), "IdPropiedad", "Canton");
            ViewData["IdUsuario"] = new SelectList(usuarioServices.GetAll(), "IdUsuario", "Apellido1");
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
                citaServices.Insert(cita);
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdPropiedad"] = new SelectList(propiedadServices.GetAll(), "IdPropiedad", "Canton", cita.IdPropiedad);
            ViewData["IdUsuario"] = new SelectList(usuarioServices.GetAll(), "IdUsuario", "Apellido1", cita.IdUsuario);
            return View(cita);
        }

        // GET: Citas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cita = await citaServices.GetOneByIdAsync((int)id);
            if (cita == null)
            {
                return NotFound();
            }
            ViewData["IdPropiedad"] = new SelectList(propiedadServices.GetAll(), "IdPropiedad", "Canton", cita.IdPropiedad);
            ViewData["IdUsuario"] = new SelectList(usuarioServices.GetAll(), "IdUsuario", "Apellido1", cita.IdUsuario);
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
                    citaServices.Update(cita);
                }
                catch (Exception ee)
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
            ViewData["IdPropiedad"] = new SelectList(propiedadServices.GetAll(), "IdPropiedad", "Canton", cita.IdPropiedad);
            ViewData["IdUsuario"] = new SelectList(usuarioServices.GetAll(), "IdUsuario", "Apellido1", cita.IdUsuario);
            return View(cita);
        }

        private bool CitaExists(int id)
        {
            return (citaServices.GetOneByIdAsync((int)id) != null);
        }

        // GET: Citas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cita = await citaServices.GetOneByIdAsync((int)id);
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
            var cita = await citaServices.GetOneByIdAsync((int)id);
            citaServices.Delete(cita);
            return RedirectToAction(nameof(Index));
        }
    }
}
