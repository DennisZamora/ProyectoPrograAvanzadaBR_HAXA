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
    public class CategoriaController : Controller
    {
        private readonly NDbContext _context;
        private readonly IMapper _mapper;
        public CategoriaController(NDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/Categorias
        [HttpGet]
        public async Task<ActionResult<IEnumerable<models.Categoria>>> GetCategoria()
        {
            try
            {
                var res = new BE.BS.Categoria(_context).GetAll();
                List<models.Categoria> mapaAux = _mapper.Map<IEnumerable<data.Categoria>, IEnumerable<models.Categoria>>(res).ToList();
                return mapaAux;
            }
            catch (Exception ee)
            {

                throw;
            }
        }

        // GET: api/Categoria/5
        [HttpGet("{id}")]
        public async Task<ActionResult<models.Categoria>> GetCategoria(int id)
        {
            var Categoria = new BE.BS.Categoria(_context).GetOneById(id);

            if (Categoria == null)
            {
                return NotFound();
            }
            models.Categoria mapaAux = _mapper.Map<data.Categoria, models.Categoria>(Categoria);

            return mapaAux;
        }

        // PUT: api/Categoria/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCategoria(int id, models.Categoria Categoria)
        {
            if (id != Categoria.IdCategoria)
            {
                return BadRequest();
            }

            try
            {
                data.Categoria mapaAux = _mapper.Map<models.Categoria, data.Categoria>(Categoria);
                new BE.BS.Categoria(_context).Update(mapaAux);
            }
            catch (Exception)
            {
                if (!CategoriaExists(id))
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

        // POST: api/Categoria
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<models.Categoria>> PostCategoria(models.Categoria Categoria)
        {
            try
            {
                data.Categoria mapaAux = _mapper.Map<models.Categoria, data.Categoria>(Categoria);//Rev
                new BE.BS.Categoria(_context).Insert(mapaAux);
            }
            catch (Exception)
            {
                BadRequest();
            }


            return CreatedAtAction("GetCategoria", new { id = Categoria.IdCategoria }, Categoria);
        }

        // DELETE: api/Categoria/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<models.Categoria>> DeleteCategoria(int id)
        {
            var Categoria = new BE.BS.Categoria(_context).GetOneById(id);
            if (Categoria == null)
            {
                return NotFound();
            }

            try
            {
                new BE.BS.Categoria(_context).Delete(Categoria);
            }
            catch (Exception)
            {
                BadRequest();
            }
            models.Categoria mapaAux = _mapper.Map<data.Categoria, models.Categoria>(Categoria);
            return mapaAux;
        }

        private bool CategoriaExists(int id)
        {
            return (new BE.BS.Categoria(_context).GetOneById(id) != null);
        }
    }
}
