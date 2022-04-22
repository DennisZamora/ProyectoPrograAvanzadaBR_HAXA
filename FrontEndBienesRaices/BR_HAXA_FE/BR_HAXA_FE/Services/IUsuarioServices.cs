using BR_HAXA_FE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BR_HAXA_FE.Services
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
