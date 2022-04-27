using BR_HAXA_FE.IDENTITY.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BR_HAXA_FE.IDENTITY.Services
{
    public interface IEmpleadoServices
    {
        void Insert(Empleado t);
        void Update(Empleado t);
        void Delete(Empleado t);
        IEnumerable<Empleado> GetAll();
        Empleado GetOneById(int id);
        Task<IEnumerable<Empleado>> GetAllAsync();
        Task<Empleado> GetOneByIdAsync(int id);
    }
}
