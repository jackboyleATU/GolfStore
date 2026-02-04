using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GolfStore.DataAccess.Repositorys
{
    public interface IRepo<T> where T : class
    {
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
        T? Get(int id);
        IEnumerable<T> GetAll(string includeProperties = "");
    }
}
