using BE.DAL.DO.Objects;
using BE.DAL.EF;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using data = BE.DAL.DO.Objects;

namespace BE.DAL.Repository
{
    public class RepositoryUsuario : Repository<data.Usuario>, IRepositoryUsuario
    {
        public RepositoryUsuario(NDbContext _dbContext) : base(_dbContext)
        {

        }
        public async Task<IEnumerable<Usuario>> GetAllAsync()
        {
            return await _db.Usuario.Include(n => n.IdRol).ToListAsync();
        }

        public async Task<Usuario> GetOneByIdAsync(int id)
        {
            return await _db.Usuario.Include(n => n.IdRol).SingleOrDefaultAsync(n => n.IdUsuario == id);
        }

        private NDbContext _db { get { return dbContext as NDbContext; } }
    }
}
