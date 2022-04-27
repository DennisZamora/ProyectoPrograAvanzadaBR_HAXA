using BR_HAXA_FE.IDENTITY.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BR_HAXA_FE.IDENTITY.Services
{
    public interface IPropiedadServices
    {
        void Insert(Propiedad t);
        void Update(Propiedad t);
        void Delete(Propiedad t);
        IEnumerable<Propiedad> GetAll();
        Propiedad GetOneById(int id);
        Task<IEnumerable<Propiedad>> GetAllAsync();
        Task<Propiedad> GetOneByIdAsync(int id);
    }
}
