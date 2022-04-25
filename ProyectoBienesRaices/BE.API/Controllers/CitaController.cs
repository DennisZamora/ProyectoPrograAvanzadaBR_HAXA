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
    public class CitaController : Controller
    {
        private readonly NDbContext _context;
        private readonly IMapper _mapper;

        public CitaController(NDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<models.Cita>>> GetCita()
        {
            try
            {
                var respuesta = new BE.BS.Cita(_context).GetAll();
                List<models.Cita> mapaAux = _mapper.Map<IEnumerable<data.Cita>, IEnumerable<models.Cita>>(respuesta).ToList();
                return mapaAux;
            }
            catch (Exception ee)
            {

                throw;
            }
        }

        // GET: api/Cita/5
        [HttpGet("{id}")]
        public async Task<ActionResult<models.Cita>> GetCita(int id)
        {
            var usuario = new BE.BS.Cita(_context).GetOneById(id);

            if (usuario == null)
            {
                return NotFound();
            }

            models.Cita mapaAux = _mapper.Map<data.Cita, models.Cita>(usuario);
            return mapaAux;
        }

        // PUT: api/Cita/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCita(int id, models.Cita Cita)
        {
            if (id != Cita.IdCita)
            {
                return BadRequest();
            }

            try
            {
                data.Cita mapaAux = _mapper.Map<models.Cita, data.Cita>(Cita);
                new BE.BS.Cita(_context).Update(mapaAux);
            }
            catch (Exception ex)
            {
                if (!CitaExists(id))
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

        // POST: api/Cita
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<models.Cita>> PostCita(models.Cita Cita)
        {
            try
            {
                data.Cita mapaAux = _mapper.Map<models.Cita, data.Cita>(Cita);
                new BE.BS.Cita(_context).Insert(mapaAux);
            }
            catch (Exception)
            {
                BadRequest();
            };

            return CreatedAtAction("GetCita", new { id = Cita.IdCita }, Cita);
        }

        // DELETE: api/Cita/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<models.Cita>> DeleteCita(int id)
        {
            var Cita = new BE.BS.Cita(_context).GetOneById(id);
            if (Cita == null)
            {
                return NotFound();
            }

            try
            {
                new BE.BS.Cita(_context).Delete(Cita);
            }
            catch (Exception)
            {
                BadRequest();
            }

            models.Cita mapaAux = _mapper.Map<data.Cita, models.Cita>(Cita);
            return mapaAux;
        }

        private bool CitaExists(int id)
        {
            return (new BE.BS.Cita(_context).GetOneById(id) != null);
        }
    }
}
