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
    public class PropiedadController : Controller
    {
        private readonly NDbContext _context;
        private readonly IMapper _mapper;
        public PropiedadController(NDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/Propiedad
        [HttpGet]
        public async Task<ActionResult<IEnumerable<models.Propiedad>>> GetPropiedad()
        {
            var res = new BE.BS.Propiedad(_context).GetAll();
            List<models.Propiedad> mapaAux = _mapper.Map<IEnumerable<data.Propiedad>, IEnumerable<models.Propiedad>>(res).ToList();
            return mapaAux;
        }

        // GET: api/Propiedad/5
        [HttpGet("{id}")]
        public async Task<ActionResult<models.Propiedad>> GetPropiedad(int id)
        {
            var Propiedad = new BE.BS.Propiedad(_context).GetOneById(id);

            if (Propiedad == null)
            {
                return NotFound();
            }
            models.Propiedad mapaAux = _mapper.Map<data.Propiedad, models.Propiedad>(Propiedad);

            return mapaAux;
        }

        // PUT: api/Propiedad/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPropiedad(int id, models.Propiedad Propiedad)
        {
            if (id != Propiedad.IdPropiedad)
            {
                return BadRequest();
            }

            try
            {
                data.Propiedad mapaAux = _mapper.Map<models.Propiedad, data.Propiedad>(Propiedad);
                new BE.BS.Propiedad(_context).Update(mapaAux);
            }
            catch (Exception)
            {
                if (!PropiedadExists(id))
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

        // POST: api/Propiedad
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<models.Propiedad>> PostPropiedad(models.Propiedad Propiedad)
        {
            try
            {
                data.Propiedad mapaAux = _mapper.Map<models.Propiedad, data.Propiedad>(Propiedad);//Rev
                new BE.BS.Propiedad(_context).Insert(mapaAux);
            }
            catch (Exception)
            {
                BadRequest();
            }


            return CreatedAtAction("GetPropiedad", new { id = Propiedad.IdPropiedad }, Propiedad);
        }

        // DELETE: api/Propiedad/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<models.Propiedad>> DeletePropiedad(int id)
        {
            var Propiedad = new BE.BS.Propiedad(_context).GetOneById(id);
            if (Propiedad == null)
            {
                return NotFound();
            }

            try
            {
                new BE.BS.Propiedad(_context).Delete(Propiedad);
            }
            catch (Exception)
            {
                BadRequest();
            }
            models.Propiedad mapaAux = _mapper.Map<data.Propiedad, models.Propiedad>(Propiedad);
            return mapaAux;
        }

        private bool PropiedadExists(int id)
        {
            return (new BE.BS.Propiedad(_context).GetOneById(id) != null);
        }
    }
}
