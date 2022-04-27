using BR_HAXA_FE.IDENTITY.Models;
using BR_HAXA_FE.IDENTITY.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

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
                var properties = new List<PropiedadV>();
                var prop = "";//PropiedadServices.GetAll();
                var imagen = "";//ImagenServices.GetAll();
                //properties.Add(new PropiedadV
                //{
                //    Property = prop,
                //    Img = imagen
                //});

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
