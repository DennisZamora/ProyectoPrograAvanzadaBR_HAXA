using BR_HAXA_FE.IDENTITY.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BR_HAXA_FE.IDENTITY.Services
{
    public interface IUsuarioServices
    {
        void Insert(Usuario t);
        void Update(Usuario t);
        void Delete(Usuario t);
        IEnumerable<Usuario> GetAll();
        Usuario GetOneById(int id);
        Task<IEnumerable<Usuario>> GetAllAsync();
        Task<Usuario> GetOneByIdAsync(int id);
    }
}
