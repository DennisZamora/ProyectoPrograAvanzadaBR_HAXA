using System;
using System.Collections.Generic;
using System.Text;
using data = BE.DAL.DO.Objects;
using BE.DAL.EF;
using BE.DAL.Repository;
using BE.DAL.DO;
using System.Threading.Tasks;
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
