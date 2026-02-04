using GolfStore.DataAccess.DataAccess;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GolfStore.DataAccess.Repositorys
{
    public class Repo<T> : IRepo<T> where T : class
    {
        private readonly AppDBContext _dbContext;
        internal DbSet<T> dbSet;

        public Repo(AppDBContext dbContext)
        {
            _dbContext = dbContext;
            this.dbSet = _dbContext.Set<T>();
        }

        public void Add(T obj)
        {
            dbSet.Add(obj);
        }

        public void Delete(T obj)
        {
            dbSet.Remove(obj);
        }

        public void Update(T obj)
        {
            dbSet.Update(obj);
        }

        public T? Get(int id)
        {
            if (id == 0)
                return null;
            else
                return dbSet.Find(id);
        }

        public IEnumerable<T> GetAll(string includeProperties = "")
        {
            IQueryable<T> query = dbSet;

            if (!string.IsNullOrWhiteSpace(includeProperties))
            {
                foreach (var includeProperty in includeProperties.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(includeProperty.Trim());
                }
            }

            return query.ToList();
        }


    }
}
