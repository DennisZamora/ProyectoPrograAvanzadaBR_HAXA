using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace BE.DAL.Repository
{
    public interface IRepository<T> where T : class //T is for 
    {
        IQueryable<T> AsQueryble();//Para poder utilizare asQuerable es como un get All pero generico
        IEnumerable<T> GetAll();// 11 y 12 me deja manipular mas los datos a bajo nivel. 11 es mas rapido
        IEnumerable<T> Search(Expression<Func<T, bool>> predicado);// 13 es mas rapido que los anteriores
        T GetOne(Expression<Func<T, bool>> predicado);// obtiene un objeto mediante un predicado
        T GetOnebyID(int id);//obtiene un ID

        void Insert(T t);
        void Update(T t);
        void Delete(T t);
        void Commit();
        //Bulk (Hace las cosas masivo
        void AddRange(IEnumerable<T> t);// pasa genericamente cualquier clase y el hace el proceso
        void UpdateRange(IEnumerable<T> t);
        void RemoveRange(IEnumerable<T> t);
    }
}
