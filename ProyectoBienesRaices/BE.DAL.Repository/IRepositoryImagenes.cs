using System.Collections.Generic;
using System.Threading.Tasks;
using data = BE.DAL.DO.Objects;

namespace BE.DAL.Repository
{
    public interface IRepositoryImagenes : IRepository<data.Imagenes>
    {
        Task<IEnumerable<data.Imagenes>> GetAllAsync();
        Task<data.Imagenes> GetOneByIdAsync(int id);
    }
}
