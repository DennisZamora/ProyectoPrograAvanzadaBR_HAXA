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
    public class ImagenesController : Controller
    {
        private readonly NDbContext _context;
        private readonly IMapper _mapper;

        public ImagenesController(NDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<models.Imagenes>>> GetImagenes()
        {
            try
            {
                var respuesta = new BE.BS.Imagenes(_context).GetAll();
                List<models.Imagenes> mapaAux = _mapper.Map<IEnumerable<data.Imagenes>, IEnumerable<models.Imagenes>>(respuesta).ToList();
                return mapaAux;
            }
            catch (Exception ee)
            {

                throw;
            }
        }

        // GET: api/Imagenes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<models.Imagenes>> GetImagenes(int id)
        {
            var usuario = new BE.BS.Imagenes(_context).GetOneById(id);

            if (usuario == null)
            {
                return NotFound();
            }

            models.Imagenes mapaAux = _mapper.Map<data.Imagenes, models.Imagenes>(usuario);
            return mapaAux;
        }

        // PUT: api/Imagenes/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutImagenes(int id, models.Imagenes Imagenes)
        {
            if (id != Imagenes.IdImagen)
            {
                return BadRequest();
            }

            try
            {
                data.Imagenes mapaAux = _mapper.Map<models.Imagenes, data.Imagenes>(Imagenes);
                new BE.BS.Imagenes(_context).Update(mapaAux);
            }
            catch (Exception ex)
            {
                if (!ImagenesExists(id))
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

        // POST: api/Imagenes
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<models.Imagenes>> PostImagenes(models.Imagenes Imagenes)
        {
            try
            {
                data.Imagenes mapaAux = _mapper.Map<models.Imagenes, data.Imagenes>(Imagenes);
                new BE.BS.Imagenes(_context).Insert(mapaAux);
            }
            catch (Exception)
            {
                BadRequest();
            };

            return CreatedAtAction("GetImagenes", new { id = Imagenes.IdImagen }, Imagenes);
        }

        // DELETE: api/Imagenes/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<models.Imagenes>> DeleteImagenes(int id)
        {
            var Imagenes = new BE.BS.Imagenes(_context).GetOneById(id);
            if (Imagenes == null)
            {
                return NotFound();
            }

            try
            {
                new BE.BS.Imagenes(_context).Delete(Imagenes);
            }
            catch (Exception)
            {
                BadRequest();
            }

            models.Imagenes mapaAux = _mapper.Map<data.Imagenes, models.Imagenes>(Imagenes);
            return mapaAux;
        }

        private bool ImagenesExists(int id)
        {
            return (new BE.BS.Imagenes(_context).GetOneById(id) != null);
        }
    }
}
