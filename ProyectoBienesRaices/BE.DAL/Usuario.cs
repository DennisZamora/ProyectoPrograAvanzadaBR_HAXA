using BE.DAL.DO;
using BE.DAL.EF;
using BE.DAL.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;
using data = BE.DAL.DO.Objects;

namespace BE.DAL
{
    public class Usuario : ICRUD<data.Usuario>
    {
        private RepositoryUsuario repo;
        public Usuario(NDbContext dbContext)
        {
            repo = new RepositoryUsuario(dbContext);
        }

        public void Delete(data.Usuario t)
        {
            repo.Delete(t);
            repo.Commit();
        }

        public IEnumerable<data.Usuario> GetAll()
        {
            return repo.GetAll();
        }

        public Task<IEnumerable<data.Usuario>> GetAllAsync()
        {
            return repo.GetAllAsync();
        }

        public data.Usuario GetOneById(int id)
        {
            return repo.GetOnebyID(id);
        }

        public Task<data.Usuario> GetOneByIdAsync(int id)
        {
            return repo.GetOneByIdAsync(id);
        }

        public void Insert(data.Usuario t)
        {
            repo.Insert(t);
            repo.Commit();
        }

        public void Update(data.Usuario t)
        {
            repo.Update(t);
            repo.Commit();
        }

    }
}
