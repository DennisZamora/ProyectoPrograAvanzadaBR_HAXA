using BR_HAXA_FE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BR_HAXA_FE.Services
{
    public interface ICategoriaServices
    {
         void Insert(Categoria t);
        void Update(Categoria t);
        void Delete(Categoria t);
        IEnumerable<Categoria> GetAll();
        Categoria GetOneById(int id);
        Task<IEnumerable<Categoria>> GetAllAsync();
        Task<Categoria> GetOneByIdAsync(int id);
    }
}
