using Data.enti.DatabaseContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppLication.Generic
{
    public abstract class  GenericRepository<T>: IGenericRepository<T> where T:class
    {
        protected readonly DbBanHang _context;
        public GenericRepository(DbBanHang context)
        {
            _context = context;
        }
        public T Get(int id)
        {
            return _context.Set<T>().Find(id);
        }
        public IEnumerable<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public void Add(T entity)
        {
            _context.Set<T>().Add(entity);
            
        }

        public void Delete(string id)
        {
            var x = _context.Set<T>().Find(id);
            _context.Set<T>().Remove(x);
            
        }
        public void Update(T entity)
        {
            _context.Set<T>().Update(entity);

        }
    }
}
