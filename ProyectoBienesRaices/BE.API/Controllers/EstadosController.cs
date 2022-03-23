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
    public class EstadosController : Controller
    {
        private readonly NDbContext _context;
        private readonly IMapper _mapper;
        public EstadosController(NDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/Estados
        [HttpGet]
        public async Task<ActionResult<IEnumerable<models.Estado>>> GetEstado()
        {
            var res = new BE.BS.Estado(_context).GetAll();
            List<models.Estado> mapaAux = _mapper.Map<IEnumerable<data.Estado>, IEnumerable<models.Estado>>(res).ToList();
            return mapaAux;
        }

        // GET: api/Estado/5
        [HttpGet("{id}")]
        public async Task<ActionResult<models.Estado>> GetEstado(int id)
        {
            var Estado = new BE.BS.Estado(_context).GetOneById(id);

            if (Estado == null)
            {
                return NotFound();
            }
            models.Estado mapaAux = _mapper.Map<data.Estado, models.Estado>(Estado);

            return mapaAux;
        }

        // PUT: api/Estado/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEstado(int id, models.Estado Estado)
        {
            if (id != Estado.IdEstado)
            {
                return BadRequest();
            }

            try
            {
                data.Estado mapaAux = _mapper.Map<models.Estado, data.Estado>(Estado);
                new BE.BS.Estado(_context).Update(mapaAux);
            }
            catch (Exception)
            {
                if (!EstadoExists(id))
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

        // POST: api/Estado
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<models.Estado>> PostEstado(models.Estado Estado)
        {
            try
            {
                data.Estado mapaAux = _mapper.Map<models.Estado, data.Estado>(Estado);//Rev
                new BE.BS.Estado(_context).Insert(mapaAux);
            }
            catch (Exception)
            {
                BadRequest();
            }


            return CreatedAtAction("GetEstado", new { id = Estado.IdEstado }, Estado);
        }

        // DELETE: api/Estado/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<models.Estado>> DeleteEstado(int id)
        {
            var Estado = new BE.BS.Estado(_context).GetOneById(id);
            if (Estado == null)
            {
                return NotFound();
            }

            try
            {
                new BE.BS.Estado(_context).Delete(Estado);
            }
            catch (Exception)
            {
                BadRequest();
            }
            models.Estado mapaAux = _mapper.Map<data.Estado, models.Estado>(Estado);
            return mapaAux;
        }

        private bool EstadoExists(int id)
        {
            return (new BE.BS.Estado(_context).GetOneById(id) != null);
        }
    }
}
