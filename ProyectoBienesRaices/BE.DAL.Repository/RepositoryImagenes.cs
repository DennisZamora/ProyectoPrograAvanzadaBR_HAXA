using BE.DAL.DO.Objects;
using BE.DAL.EF;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using data = BE.DAL.DO.Objects;

namespace BE.DAL.Repository
{
    public class RepositoryImagenes : Repository<data.Imagenes>, IRepositoryImagenes
    {
        public RepositoryImagenes(NDbContext _dbContext) : base(_dbContext)
        {

        }
        public async Task<IEnumerable<Imagenes>> GetAllAsync()
        {
            return await _db.Imagenes.Include(n => n.IdPropiedad).ToListAsync();
        }

        public async Task<Imagenes> GetOneByIdAsync(int id)
        {
            return await _db.Imagenes.Include(n => n.IdPropiedad).SingleOrDefaultAsync(n => n.IdImagen == id);
        }

        private NDbContext _db { get { return dbContext as NDbContext; } }
    }
}
