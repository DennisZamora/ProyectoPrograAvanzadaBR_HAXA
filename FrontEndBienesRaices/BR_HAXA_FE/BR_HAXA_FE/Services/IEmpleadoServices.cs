using BR_HAXA_FE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BR_HAXA_FE.Services
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
