using BE.DAL.DO;
using BE.DAL.EF;
using System.Collections.Generic;
using System.Threading.Tasks;
using dal = BE.DAL;
using data = BE.DAL.DO.Objects;

namespace BE.BS
{
    public class Empleado : ICRUD<data.Empleado>
    {
        private dal.Empleado _dal;
        public Empleado(NDbContext dbContext)
        {
            _dal = new dal.Empleado(dbContext);
        }

        public void Delete(data.Empleado t)
        {
            _dal.Delete(t);
        }

        public IEnumerable<data.Empleado> GetAll()
        {
            return _dal.GetAll();
        }

        public Task<IEnumerable<data.Empleado>> GetAllAsync()
        {
            throw new System.NotImplementedException();
        }

        public data.Empleado GetOneById(int id)
        {
            return _dal.GetOneById(id);
        }

        public Task<data.Empleado> GetOneByIdAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Insert(data.Empleado t)
        {
            _dal.Insert(t);
        }

        public void Update(data.Empleado t)
        {
            _dal.Update(t);
        }
    }
}
