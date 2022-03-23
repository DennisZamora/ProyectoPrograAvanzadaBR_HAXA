using BE.DAL.DO.Objects;
using BE.DAL.EF;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using data = BE.DAL.DO.Objects;

namespace BE.DAL.Repository
{
    public class RepositoryPropiedad : Repository<data.Propiedad>, IRepositoryPropiedad
    {
        public RepositoryPropiedad(NDbContext _dbContext) : base(_dbContext)
        {

        }
        public async Task<IEnumerable<Propiedad>> GetAllAsync()
        {
            return await _db.Propiedad.Include(n => n.IdCategoria).ToListAsync();
        }

        public async Task<Propiedad> GetOneByIDAsync(int id)
        {
            return await _db.Propiedad.Include(n => n.IdCategoria).SingleOrDefaultAsync(n => n.IdPropiedad == id);
        }
        private NDbContext _db { get { return dbContext as NDbContext; } }
    }
}
