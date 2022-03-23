using AutoMapper;
using BE.DAL.DO.Objects;
using BE.DAL.EF;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using data = BE.DAL.DO.Objects;
using models = BE.API.DataModels;

namespace BE.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : Controller
    {
        private readonly NDbContext _context;
        private readonly IMapper _mapper;

        public UsuarioController(NDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<models.Usuario>>> GetUsuario()
        {
            try
            {
                var respuesta = new BE.BS.Usuario(_context).GetAll();
                List<models.Usuario> mapaAux = _mapper.Map<IEnumerable<data.Usuario>, IEnumerable<models.Usuario>>(respuesta).ToList();
                return mapaAux;
            }
            catch (Exception ee)
            {

                throw;
            }
        }

        // GET: api/Usuario/5
        [HttpGet("{id}")]
        public async Task<ActionResult<models.Usuario>> GetUsuario(int id)
        {
            var usuario = new BE.BS.Usuario(_context).GetOneById(id);

            if (usuario == null)
            {
                return NotFound();
            }

            models.Usuario mapaAux = _mapper.Map<data.Usuario, models.Usuario>(usuario);
            return mapaAux;
        }

        // PUT: api/Usuario/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUsuario(int id, models.Usuario Usuario)
        {
            if (id != Usuario.IdUsuario)
            {
                return BadRequest();
            }

            try
            {
                data.Usuario mapaAux = _mapper.Map<models.Usuario, data.Usuario>(Usuario);
                new BE.BS.Usuario(_context).Update(mapaAux);
            }
            catch (Exception ex)
            {
                if (!UsuarioExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Usuario
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<models.Usuario>> PostUsuario(models.Usuario Usuario)
        {
            try
            {
                data.Usuario mapaAux = _mapper.Map<models.Usuario, data.Usuario>(Usuario);
                new BE.BS.Usuario(_context).Insert(mapaAux);
            }
            catch (Exception)
            {
                BadRequest();
            };

            return CreatedAtAction("GetUsuario", new { id = Usuario.IdUsuario }, Usuario);
        }

        // DELETE: api/Usuario/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<models.Usuario>> DeleteUsuario(int id)
        {
            var Usuario = new BE.BS.Usuario(_context).GetOneById(id);
            if (Usuario == null)
            {
                return NotFound();
            }

            try
            {
                new BE.BS.Usuario(_context).Delete(Usuario);
            }
            catch (Exception)
            {
                BadRequest();
            }

            models.Usuario mapaAux = _mapper.Map<data.Usuario, models.Usuario>(Usuario);
            return mapaAux;
        }

        private bool UsuarioExists(int id)
        {
            return (new BE.BS.Usuario(_context).GetOneById(id) != null);
        }
    }
}
