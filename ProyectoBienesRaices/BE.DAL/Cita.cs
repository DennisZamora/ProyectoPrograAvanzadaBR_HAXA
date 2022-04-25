using BE.DAL.DO;
using BE.DAL.EF;
using BE.DAL.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;
using data = BE.DAL.DO.Objects;

namespace BE.DAL
{
    public class Cita : ICRUD<data.Cita>
    {
        private RepositoryCita repo;
        public Cita(NDbContext dbContext)
        {
            repo = new RepositoryCita(dbContext);
        }

        public void Delete(data.Cita t)
        {
            repo.Delete(t);
            repo.Commit();
        }

        public IEnumerable<data.Cita> GetAll()
        {
            return repo.GetAll();
        }

        public Task<IEnumerable<data.Cita>> GetAllAsync()
        {
            return repo.GetAllAsync();
        }

        public data.Cita GetOneById(int id)
        {
            return repo.GetOnebyID(id);
        }

        public Task<data.Cita> GetOneByIdAsync(int id)
        {
            return repo.GetOneByIdAsync(id);
        }

        public void Insert(data.Cita t)
        {
            repo.Insert(t);
            repo.Commit();
        }

        public void Update(data.Cita t)
        {
            repo.Update(t);
            repo.Commit();
        }

    }
}
