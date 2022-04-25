using BE.DAL.DO;
using BE.DAL.EF;
using System.Collections.Generic;
using System.Threading.Tasks;
using dal = BE.DAL;
using data = BE.DAL.DO.Objects;


namespace BE.BS
{
    public class Cita : ICRUD<data.Cita>
    {
        private dal.Cita _dal;
        public Cita(NDbContext dbContext)
        {
            _dal = new dal.Cita(dbContext);
        }

        public void Delete(data.Cita t)
        {
            _dal.Delete(t);
        }

        public IEnumerable<data.Cita> GetAll()
        {
            return _dal.GetAll();
        }

        public Task<IEnumerable<data.Cita>> GetAllAsync()
        {
            throw new System.NotImplementedException();
        }

        public data.Cita GetOneById(int id)
        {
            return _dal.GetOneById(id);
        }

        public Task<data.Cita> GetOneByIdAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Insert(data.Cita t)
        {
            _dal.Insert(t);
        }

        public void Update(data.Cita t)
        {
            _dal.Update(t);
        }
    }
}
