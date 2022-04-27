using BR_HAXA_FE.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BR_HAXA_FE.Services
{
    public interface IRolServices
    {
        void Insert(Rol t);
        void Update(Rol t);
        void Delete(Rol t);
        IEnumerable<Rol> GetAll();
        Rol GetOneById(int id);
        Task<IEnumerable<Rol>> GetAllAsync();
        Task<Rol> GetOneByIdAsync(int id);
    }
}
