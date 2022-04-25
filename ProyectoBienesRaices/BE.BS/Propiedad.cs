using BE.DAL.DO;
using BE.DAL.EF;
using System.Collections.Generic;
using System.Threading.Tasks;
using dal = BE.DAL;
using data = BE.DAL.DO.Objects;


namespace BE.BS
{
    public class Propiedad : ICRUD<data.Propiedad>
    {
        private dal.Propiedad _dal;
        public Propiedad(NDbContext dbContext)
        {
            _dal = new dal.Propiedad(dbContext);
        }

        public void Delete(data.Propiedad t)
        {
            _dal.Delete(t);
        }

        public IEnumerable<data.Propiedad> GetAll()
        {
            return _dal.GetAll();
        }

        public Task<IEnumerable<data.Propiedad>> GetAllAsync()
        {
            throw new System.NotImplementedException();
        }

        public data.Propiedad GetOneById(int id)
        {
            return _dal.GetOneById(id);
        }

        public Task<data.Propiedad> GetOneByIdAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Insert(data.Propiedad t)
        {
            _dal.Insert(t);
        }

        public void Update(data.Propiedad t)
        {
            _dal.Update(t);
        }
    }
}

