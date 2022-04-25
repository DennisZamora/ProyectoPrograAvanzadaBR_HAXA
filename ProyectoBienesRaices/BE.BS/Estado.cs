using BE.DAL.DO;
using BE.DAL.EF;
using System.Collections.Generic;
using System.Threading.Tasks;
using dal = BE.DAL;
using data = BE.DAL.DO.Objects;



namespace BE.BS
{
    public class Estado : ICRUD<data.Estado>
    {
        private dal.Estado _dal;
        public Estado(NDbContext dbContext)
        {
            _dal = new dal.Estado(dbContext);
        }

        public void Delete(data.Estado t)
        {
            _dal.Delete(t);
        }

        public IEnumerable<data.Estado> GetAll()
        {
            return _dal.GetAll();
        }

        public Task<IEnumerable<data.Estado>> GetAllAsync()
        {
            throw new System.NotImplementedException();
        }

        public data.Estado GetOneById(int id)
        {
            return _dal.GetOneById(id);
        }

        public Task<data.Estado> GetOneByIdAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Insert(data.Estado t)
        {
            _dal.Insert(t);
        }

        public void Update(data.Estado t)
        {
            _dal.Update(t);
        }
    }
}
