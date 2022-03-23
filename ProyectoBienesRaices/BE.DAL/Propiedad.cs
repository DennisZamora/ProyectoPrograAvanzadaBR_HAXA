using BE.DAL.DO;
using BE.DAL.EF;
using BE.DAL.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using data = BE.DAL.DO.Objects;

namespace BE.DAL
{
    public class Propiedad : ICRUD<data.Propiedad>
    {
        private Repository<data.Propiedad> repo;

        public Propiedad(NDbContext dbContext)
        {
            repo = new Repository<data.Propiedad>(dbContext);

        }

        public void Delete(data.Propiedad t)
        {
            repo.Delete(t);
            repo.Commit();
        }

        public IEnumerable<data.Propiedad> GetAll()
        {
            return repo.GetAll();
        }

        public Task<IEnumerable<data.Propiedad>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public data.Propiedad GetOneById(int id)
        {
            return repo.GetOnebyID(id);
        }

        public Task<data.Propiedad> GetOneByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(data.Propiedad t)
        {
            try
            {
                repo.Insert(t);
                repo.Commit();
            }
            catch (Exception ee)
            {

                throw;
            }
        }

        public void Update(data.Propiedad t)
        {
            repo.Update(t);
            repo.Commit();
        }
    }
}

