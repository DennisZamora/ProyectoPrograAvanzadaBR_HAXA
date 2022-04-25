
using BE.DAL.DO;
using BE.DAL.EF;
using System.Collections.Generic;
using System.Threading.Tasks;
using dal = BE.DAL;
using data = BE.DAL.DO.Objects;

namespace BE.BS
{
    public class Categoria : ICRUD<data.Categoria>
    {
        private dal.Categoria _dal;
        public Categoria(NDbContext dbContext)
        {
            _dal = new dal.Categoria(dbContext);
        }

        public void Delete(data.Categoria t)
        {
            _dal.Delete(t);
        }

        public IEnumerable<data.Categoria> GetAll()
        {
            return _dal.GetAll();
        }

        public Task<IEnumerable<data.Categoria>> GetAllAsync()
        {
            throw new System.NotImplementedException();
        }

        public data.Categoria GetOneById(int id)
        {
            return _dal.GetOneById(id);
        }

        public Task<data.Categoria> GetOneByIdAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Insert(data.Categoria t)
        {
            _dal.Insert(t);
        }

        public void Update(data.Categoria t)
        {
            _dal.Update(t);
        }
    }
}
