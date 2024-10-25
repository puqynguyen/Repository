using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IGenericRepository<T> where T : class
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        T GetById(int id);
        IEnumerable<T> GetAll();
    }

    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly CarStoreContext _context;
        private DbSet<T> _dbSet;

        public GenericRepository(CarStoreContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        public void Add(T entity)
        {
            _dbSet.Add(entity);
            _context.SaveChanges();
        }

        public void Update(T entity)
        {
            _dbSet.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void Delete(T entity)
        {
            if (_context.Entry(entity).State == EntityState.Detached)
            {
                _dbSet.Attach(entity);
            }
            _dbSet.Remove(entity);
            _context.SaveChanges();
        }

        public T GetById(int id)
        {
            return _dbSet.Find(id);
        }

        public IEnumerable<T> GetAll()
        {
            return _dbSet.ToList();
        }
    }
}
