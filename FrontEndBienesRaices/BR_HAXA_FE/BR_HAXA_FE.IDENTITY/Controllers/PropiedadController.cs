using BR_HAXA_FE.IDENTITY.Models;
using BR_HAXA_FE.IDENTITY.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BR_HAXA_FE.IDENTITY.Controllers
{
    public class PropiedadsController : Controller
    {
        private readonly IUsuarioServices usuarioServices;
        private readonly ICategoriaServices categoriaServices;
        private readonly IEstadoServices estadoServices;
        private readonly IPropiedadServices propiedadServices;

        public PropiedadsController(IUsuarioServices usuarioServices, ICategoriaServices categoriaServices, IEstadoServices estadoServices, IPropiedadServices propiedadServices)
        {
            this.usuarioServices = usuarioServices;
            this.categoriaServices = categoriaServices;
            this.estadoServices = estadoServices;
            this.propiedadServices = propiedadServices;
        }

        //public IActionResult Index()
        //{
        //    return View();
        //}

        // GET: Propiedads
        public async Task<IActionResult> Index()
        {
            //var bienesRaicesHaxaPrograContext = _context.Propiedad.Include(p => p.IdCategoriaNavigation).Include(p => p.IdEstadoNavigation).Include(p => p.IdUsuarioNavigation);
            return View(await propiedadServices.GetAllAsync());
        }

        // GET: Propiedads/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var propiedad = await propiedadServices.GetOneByIdAsync((int)id);
            if (propiedad == null)
            {
                return NotFound();
            }

            return View(propiedad);
        }

        // GET: Propiedads/Create
        public IActionResult Create()
        {
            ViewData["IdCategoria"] = new SelectList(categoriaServices.GetAll(), "IdCategoria", "Nombre");
            ViewData["IdEstado"] = new SelectList(estadoServices.GetAll(), "IdEstado", "Nombre");
            ViewData["IdUsuario"] = new SelectList(usuarioServices.GetAll(), "IdUsuario", "Apellido1");
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
                propiedadServices.Insert(propiedad);
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdCategoria"] = new SelectList(categoriaServices.GetAll(), "IdCategoria", "Nombre", propiedad.IdCategoria);
            ViewData["IdEstado"] = new SelectList(estadoServices.GetAll(), "IdEstado", "Nombre", propiedad.IdEstado);
            ViewData["IdUsuario"] = new SelectList(usuarioServices.GetAll(), "IdUsuario", "Apellido1", propiedad.IdUsuario);
            return View(propiedad);
        }

        // GET: Propiedads/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var propiedad = await propiedadServices.GetOneByIdAsync((int)id);
            if (propiedad == null)
            {
                return NotFound();
            }
            ViewData["IdCategoria"] = new SelectList(categoriaServices.GetAll(), "IdCategoria", "Nombre", propiedad.IdCategoria);
            ViewData["IdEstado"] = new SelectList(estadoServices.GetAll(), "IdEstado", "Nombre", propiedad.IdEstado);
            ViewData["IdUsuario"] = new SelectList(usuarioServices.GetAll(), "IdUsuario", "Apellido1", propiedad.IdUsuario);
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
                    propiedadServices.Update(propiedad);
                }
                catch (Exception ee)
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
            ViewData["IdCategoria"] = new SelectList(categoriaServices.GetAll(), "IdCategoria", "Nombre", propiedad.IdCategoria);
            ViewData["IdEstado"] = new SelectList(estadoServices.GetAll(), "IdEstado", "Nombre", propiedad.IdEstado);
            ViewData["IdUsuario"] = new SelectList(usuarioServices.GetAll(), "IdUsuario", "Apellido1", propiedad.IdUsuario);
            return View(propiedad);
        }

        // GET: Propiedads/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var propiedad = await propiedadServices.GetOneByIdAsync((int)id);
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
            var propiedad = await propiedadServices.GetOneByIdAsync((int)id);
            propiedadServices.Delete(propiedad);
            return RedirectToAction(nameof(Index));
        }

        private bool PropiedadExists(int id)
        {
            return (propiedadServices.GetOneByIdAsync((int)id) != null);
        }
    }
}
