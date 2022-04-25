using System.Collections.Generic;
using System.Threading.Tasks;

namespace BE.DAL.DO
{
    public interface ICRUD<T>
    {
        void Insert(T t);
        void Update(T t);
        void Delete(T t);
        IEnumerable<T> GetAll();
        T GetOneById(int id);

        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetOneByIdAsync(int id);
    }
}
