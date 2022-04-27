using BR_HAXA_FE.IDENTITY.Models;
using BR_HAXA_FE.IDENTITY.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace BR_HAXA_FE.IDENTITY.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            try
            {
                PropiedadServices ps = new PropiedadServices();
                ImagenesServices im = new ImagenesServices();
                var properties = new List<PropiedadV>();
                List<Propiedad> props = ps.GetAll().ToList();
                List<Imagenes> imagenes=im.GetAll().ToList();
                foreach (var item in props)
                {
                    List<Imagenes> imProp=new List<Imagenes>();
                    imProp=(from x in imagenes
                            where x.IdPropiedad == item.IdPropiedad
                            select x).ToList();
                    properties.Add(new PropiedadV
                    {
                        Property = item,
                        Img = imProp
                    });
                }


                // Verificar si la lista esta vacía
                if (properties.Count > 0)
                {
                    return View("Index", properties);
                }
                else
                {
                    return View("Index", new List<PropiedadV>());
                }
            }
            catch (Exception ee)
            {
                return View("~/Shared/Error.cshtml");
            }
        }

        [HttpGet]
        public IActionResult Propiedad(int id)
        {
            PropiedadServices action = new PropiedadServices();
            try
            {
                ImagenesServices im = new ImagenesServices();
                List<Imagenes> imagenes = im.GetAll().ToList();
                List<Imagenes> imProp = new List<Imagenes>();
                var propiedad = action.GetOneById(id);
                var properties = new PropiedadV();
                
                imProp = (from x in imagenes
                          where x.IdPropiedad == id
                          select x).ToList();
                properties = new PropiedadV
                {
                    Property = propiedad,
                    Img = imProp
                };

                if (properties == null)
                {
                    return View("Error");
                }
                else
                {
                    return View("Propiedad", properties);
                }
            }
            catch (Exception)
            {
                return View("Error");
            }

        }


            public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
