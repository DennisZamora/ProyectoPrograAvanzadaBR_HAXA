using BR_HAXA_FE.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BR_HAXA_FE.Services
{
    public interface IImagenesServices
    {
        void Insert(Imagenes t);
        void Update(Imagenes t);
        void Delete(Imagenes t);
        IEnumerable<Imagenes> GetAll();
        Imagenes GetOneById(int id);
        Task<IEnumerable<Imagenes>> GetAllAsync();
        Task<Imagenes> GetOneByIdAsync(int id);
    }
}
