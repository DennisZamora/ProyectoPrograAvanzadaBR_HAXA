using BE.DAL.DO.Objects;
using BE.DAL.EF;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using data = BE.DAL.DO.Objects;

namespace BE.DAL.Repository
{
    public class RepositoryCita : Repository<data.Cita>, IRepositoryCita
    {
        public RepositoryCita(NDbContext _dbContext) : base(_dbContext)
        {

        }
        public async Task<IEnumerable<Cita>> GetAllAsync()
        {
            return await _db.Cita.Include(n => n.IdUsuario).ToListAsync();
        }

        public async Task<Cita> GetOneByIdAsync(int id)
        {
            return await _db.Cita.Include(n => n.IdUsuario).SingleOrDefaultAsync(n => n.IdCita == id);
        }

        private NDbContext _db { get { return dbContext as NDbContext; } }
    }
}
