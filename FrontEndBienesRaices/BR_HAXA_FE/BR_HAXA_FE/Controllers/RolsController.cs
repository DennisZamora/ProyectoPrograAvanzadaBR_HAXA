using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BR_HAXA_FE.Controllers
{
    public class RolsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
