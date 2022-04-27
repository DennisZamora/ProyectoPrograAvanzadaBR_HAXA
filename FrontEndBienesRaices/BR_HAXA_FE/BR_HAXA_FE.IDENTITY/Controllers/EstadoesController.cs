using BR_HAXA_FE.IDENTITY.Models;
using BR_HAXA_FE.IDENTITY.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace BR_HAXA_FE.IDENTITY.Controllers
{
    public class EstadoesController : Controller
    {
        private readonly IEstadoServices estadoServices;

        public EstadoesController(IEstadoServices estadoServices)
        {
            this.estadoServices = estadoServices;
        }

        //public IActionResult Index()
        //{
        //    return View();
        //}

        // GET: Estadoes
        public async Task<IActionResult> Index()
        {
            return View(estadoServices.GetAll());
        }

        // GET: Estadoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var estado = estadoServices.GetOneById((int)id);
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
                estadoServices.Insert(estado);
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

            var estado = estadoServices.GetOneById((int)id);
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
                    estadoServices.Update(estado);
                }
                catch (Exception ee)
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

        private bool EstadoExists(int id)
        {
            return (estadoServices.GetOneById(id) != null);
        }

        // GET: Estadoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var estado = estadoServices.GetOneById((int)id);
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
            var estado = estadoServices.GetOneById(id);
            estadoServices.Delete(estado);
            return RedirectToAction(nameof(Index));
        }
    }
}
