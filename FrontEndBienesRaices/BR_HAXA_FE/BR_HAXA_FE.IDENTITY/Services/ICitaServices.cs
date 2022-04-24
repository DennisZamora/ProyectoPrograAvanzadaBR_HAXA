using BR_HAXA_FE.IDENTITY.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BR_HAXA_FE.IDENTITY.Services
{
    public interface ICitaServices
    {
        void Insert(Cita t);
        void Update(Cita t);
        void Delete(Cita t);
        IEnumerable<Cita> GetAll();
        Cita GetOneById(int id);
        Task<IEnumerable<Cita>> GetAllAsync();
        Task<Cita> GetOneByIdAsync(int id);
    }
}
