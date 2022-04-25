using BE.DAL.DO;
using BE.DAL.EF;
using BE.DAL.Repository;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using data = BE.DAL.DO.Objects;
namespace BE.DAL
{
    public class Empleado : ICRUD<data.Empleado>
    {
        private Repository<data.Empleado> repo;
        public Empleado(NDbContext dbContext)
        {
            repo = new Repository<data.Empleado>(dbContext);
        }
        public void Delete(data.Empleado t)
        {
            repo.Delete(t);
            repo.Commit();
        }

        public IEnumerable<data.Empleado> GetAll()
        {
            return repo.GetAll();
        }

        public Task<IEnumerable<data.Empleado>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public data.Empleado GetOneById(int id)
        {
            return repo.GetOnebyID(id);
        }

        public Task<data.Empleado> GetOneByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(data.Empleado t)
        {
            repo.Insert(t);
            repo.Commit();
        }

        public void Update(data.Empleado t)
        {
            repo.Update(t);
            repo.Commit();
        }
    }
}
