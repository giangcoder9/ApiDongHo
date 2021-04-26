using System;
using System.Collections.Generic;
using System.Text;

namespace AppLication.Generic
{
    public interface IGenericRepository<T> where T: class
    {
        T Get(int id);
        IEnumerable<T> GetAll();
        void Add(T entity);
        void Delete(string id);
        void Update(T entity);
    }
}
