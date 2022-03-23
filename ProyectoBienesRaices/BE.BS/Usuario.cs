using data = BE.DAL.DO.Objects;
using dal = BE.DAL;
using BE.DAL.DO;
using BE.DAL.EF;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BE.BS
{
    public class Usuario : ICRUD<data.Usuario>
    {
        private dal.Usuario _dal;
        public Usuario(NDbContext dbContext)
        {
            _dal = new dal.Usuario(dbContext);
        }

        public void Delete(data.Usuario t)
        {
            _dal.Delete(t);
        }

        public IEnumerable<data.Usuario> GetAll()
        {
            return _dal.GetAll();
        }

        public Task<IEnumerable<data.Usuario>> GetAllAsync()
        {
            throw new System.NotImplementedException();
        }

        public data.Usuario GetOneById(int id)
        {
            return _dal.GetOneById(id);
        }

        public Task<data.Usuario> GetOneByIdAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Insert(data.Usuario t)
        {
            _dal.Insert(t);
        }

        public void Update(data.Usuario t)
        {
            _dal.Update(t);
        }
    }
}
