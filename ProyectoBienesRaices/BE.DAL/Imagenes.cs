using BE.DAL.DO;
using BE.DAL.EF;
using BE.DAL.Repository;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using data = BE.DAL.DO.Objects;

namespace BE.DAL
{
    public class Imagenes : ICRUD<data.Imagenes>
    {
        private RepositoryImagenes repo;
        public Imagenes(NDbContext dbContext)
        {
            repo = new RepositoryImagenes(dbContext);
        }

        public void Delete(data.Imagenes t)
        {
            repo.Delete(t);
            repo.Commit();
        }

        public IEnumerable<data.Imagenes> GetAll()
        {
            return repo.GetAll();
        }

        public Task<IEnumerable<data.Imagenes>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public data.Imagenes GetOneById(int id)
        {
            return repo.GetOnebyID(id);
        }

        public Task<data.Imagenes> GetOneByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(data.Imagenes t)
        {
            try
            {
                repo.Insert(t);
                repo.Commit();
            }
            catch (Exception ee)
            {

                throw;
            }
        }

        public void Update(data.Imagenes t)
        {
            repo.Update(t);
            repo.Commit();
        }
    }
}