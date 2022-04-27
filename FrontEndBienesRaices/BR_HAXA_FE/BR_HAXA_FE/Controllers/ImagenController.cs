using BR_HAXA_FE.Models;
using BR_HAXA_FE.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BR_HAXA_FE.Controllers
{
    public class ImagenController : Controller
    {
        private readonly IPropiedadServices propiedadServices;
        private readonly IImagenesServices imagenesServices;

        public ImagenController(IPropiedadServices propiedadServices, IImagenesServices imagenesServices)
        {
            this.propiedadServices = propiedadServices;
            this.imagenesServices = imagenesServices;
        }

        //public IActionResult Index()
        //{
        //    return View();
        //}

        // GET: Imagenes
        public async Task<IActionResult> Index()
        {
            //var bienesRaicesHaxaPrograContext = _context.Imagenes.Include(i => i.IdPropiedadNavigation);
            return View(await imagenesServices.GetAllAsync());
        }

        // GET: Imagenes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var imagenes = await imagenesServices.GetOneByIdAsync((int)id);
            if (imagenes == null)
            {
                return NotFound();
            }

            return View(imagenes);
        }

        // GET: Imagenes/Create
        public IActionResult Create()
        {
            ViewData["IdPropiedad"] = new SelectList(propiedadServices.GetAll(), "IdPropiedad", "Canton");
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
                imagenesServices.Insert(imagenes);
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdPropiedad"] = new SelectList(propiedadServices.GetAll(), "IdPropiedad", "Canton", imagenes.IdPropiedad);
            return View(imagenes);
        }

        // GET: Imagenes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var imagenes = await imagenesServices.GetOneByIdAsync((int)id);
            if (imagenes == null)
            {
                return NotFound();
            }
            ViewData["IdPropiedad"] = new SelectList(propiedadServices.GetAll(), "IdPropiedad", "Canton", imagenes.IdPropiedad);
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
                    imagenesServices.Update(imagenes);
                }
                catch (Exception ee)
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
            ViewData["IdPropiedad"] = new SelectList(propiedadServices.GetAll(), "IdPropiedad", "Canton", imagenes.IdPropiedad);
            return View(imagenes);
        }

        // GET: Imagenes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var imagenes = await imagenesServices.GetOneByIdAsync((int)id);
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
            var imagenes = await imagenesServices.GetOneByIdAsync((int)id);
            imagenesServices.Delete(imagenes);
            return RedirectToAction(nameof(Index));
        }

        private bool ImagenesExists(int id)
        {
            return (imagenesServices.GetOneByIdAsync((int)id) != null);
        }
    }
}
