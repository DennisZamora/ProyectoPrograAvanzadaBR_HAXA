using BE.DAL.DO;
using BE.DAL.EF;
using System.Collections.Generic;
using System.Threading.Tasks;
using dal = BE.DAL;
using data = BE.DAL.DO.Objects;

namespace BE.BS
{
    public class Imagenes : ICRUD<data.Imagenes>
    {
        private dal.Imagenes _dal;
        public Imagenes(NDbContext dbContext)
        {
            _dal = new dal.Imagenes(dbContext);
        }

        public void Delete(data.Imagenes t)
        {
            _dal.Delete(t);
        }

        public IEnumerable<data.Imagenes> GetAll()
        {
            return _dal.GetAll();
        }

        public Task<IEnumerable<data.Imagenes>> GetAllAsync()
        {
            throw new System.NotImplementedException();
        }

        public data.Imagenes GetOneById(int id)
        {
            return _dal.GetOneById(id);
        }

        public Task<data.Imagenes> GetOneByIdAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Insert(data.Imagenes t)
        {
            _dal.Insert(t);
        }

        public void Update(data.Imagenes t)
        {
            _dal.Update(t);
        }
    }
}
