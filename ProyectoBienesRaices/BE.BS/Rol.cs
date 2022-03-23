using data = BE.DAL.DO.Objects;
using dal = BE.DAL;
using BE.DAL.DO;
using BE.DAL.EF;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace BE.BS
{
    public class Rol : ICRUD<data.Rol>
    {
        private dal.Rol _dal;
        public Rol(NDbContext dbContext)
        {
            _dal = new dal.Rol(dbContext);
        }

        public void Delete(data.Rol t)
        {
            _dal.Delete(t);
        }

        public IEnumerable<data.Rol> GetAll()
        {
            return _dal.GetAll();
        }

        public Task<IEnumerable<data.Rol>> GetAllAsync()
        {
            throw new System.NotImplementedException();
        }

        public data.Rol GetOneById(int id)
        {
            return _dal.GetOneById(id);
        }

        public Task<data.Rol> GetOneByIdAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Insert(data.Rol t)
        {
            _dal.Insert(t);
        }

        public void Update(data.Rol t)
        {
            _dal.Update(t);
        }
    }
}
