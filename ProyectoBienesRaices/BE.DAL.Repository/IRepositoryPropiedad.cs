using System.Collections.Generic;
using System.Threading.Tasks;
using data = BE.DAL.DO.Objects;

namespace BE.DAL.Repository
{
    internal interface IRepositoryPropiedad : IRepository<data.Propiedad>
    {
        Task<IEnumerable<data.Propiedad>> GetAllAsync();
        Task<data.Propiedad> GetOneByIDAsync(int id);
    }
}
