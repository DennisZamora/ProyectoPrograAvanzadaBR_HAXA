using BR_HAXA_FE.IDENTITY.Models;
using BR_HAXA_FE.IDENTITY.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Threading.Tasks;

namespace BR_HAXA_FE.IDENTITY.Controllers
{
    public class UsuariosController : Controller
    {
        private readonly IUsuarioServices UsuarioServices;
        private readonly IRolServices RolServices;

        public UsuariosController(IUsuarioServices usuarioServices, IRolServices rolServices)
        {
            UsuarioServices = usuarioServices;
            RolServices = rolServices;
        }



        // GET: Usuarios
        public async Task<IActionResult> Index()
        {
            return View(await UsuarioServices.GetAllAsync());
        }

        // GET: Usuarios/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usuario = await UsuarioServices.GetOneByIdAsync((int)id);
            if (usuario == null)
            {
                return NotFound();
            }

            return View(usuario);
        }

        // GET: Usuarios/Create
        public IActionResult Create()
        {
            ViewData["IdRol"] = new SelectList(RolServices.GetAll(), "IdRol", "IdRol");
            return View();
        }

        // POST: Usuarios/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdUsuario,CedulaIdentificacion,Nombre,Apellido1,Apellido2,Telefono,Email,Password,IdRol")] Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                UsuarioServices.Insert(usuario);
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdRol"] = new SelectList(RolServices.GetAll(), "IdRol", "IdRol", usuario.IdRol);
            return View(usuario);
        }

        // GET: Usuarios/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usuario = await UsuarioServices.GetOneByIdAsync((int)id);
            if (usuario == null)
            {
                return NotFound();
            }
            ViewData["IdRol"] = new SelectList(RolServices.GetAll(), "IdRol", "IdRol", usuario.IdRol);
            return View(usuario);
        }

        // POST: Usuarios/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdUsuario,CedulaIdentificacion,Nombre,Apellido1,Apellido2,Telefono,Email,Password,IdRol")] Usuario usuario)
        {
            if (id != usuario.IdUsuario)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    UsuarioServices.Update(usuario);
                }
                catch (Exception ex)
                {
                    if (!UsuarioExists(usuario.IdUsuario))
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
            ViewData["IdRol"] = new SelectList(RolServices.GetAll(), "IdRol", "IdRol", usuario.IdRol);
            return View(usuario);
        }

        // GET: Usuarios/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usuario = await UsuarioServices.GetOneByIdAsync((int)id);
            if (usuario == null)
            {
                return NotFound();
            }

            return View(usuario);
        }

        // POST: Usuarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var usuario = await UsuarioServices.GetOneByIdAsync((int)id);
            UsuarioServices.Delete(usuario);
            return RedirectToAction(nameof(Index));
        }

        private bool UsuarioExists(int id)
        {
            return (UsuarioServices.GetOneByIdAsync((int)id) != null);
        }
    }
}
