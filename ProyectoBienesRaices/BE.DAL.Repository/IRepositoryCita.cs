using System.Collections.Generic;
using System.Threading.Tasks;
using data = BE.DAL.DO.Objects;

namespace BE.DAL.Repository
{
    public interface IRepositoryCita : IRepository<data.Cita>
    {
        Task<IEnumerable<data.Cita>> GetAllAsync();
        Task<data.Cita> GetOneByIdAsync(int id);
    }
}
