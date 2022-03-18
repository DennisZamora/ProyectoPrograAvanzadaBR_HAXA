using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace BE.DAL.Repository
{
    public class RepositoryRol<T> : IRepositoryRol<T> where T : class
    {
        public void AddRange(IEnumerable<T> t)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> AsQueryble()
        {
            throw new NotImplementedException();
        }

        public void Commit()
        {
            throw new NotImplementedException();
        }

        public void Delete(T t)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public T GetOne(Expression<Func<T, bool>> predicado)
        {
            throw new NotImplementedException();
        }

        public T GetOnebyID(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(T t)
        {
            throw new NotImplementedException();
        }

        public void RemoveRange(IEnumerable<T> t)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> Search(Expression<Func<T, bool>> predicado)
        {
            throw new NotImplementedException();
        }

        public void Update(T t)
        {
            throw new NotImplementedException();
        }

        public void UpdateRange(IEnumerable<T> t)
        {
            throw new NotImplementedException();
        }
    }
}
