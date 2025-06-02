using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using dataAccessLayer.abstracts;

namespace dataAccessLayer.concrete.repositories
{
    public class genericRepository<T> : IRepositoryDal<T> where T : class
    {
        private readonly Context _context;

        public genericRepository(Context context)
        {
            _context = context;
        }
        public void delete(T p)
        {
            _context.Remove(p);
            _context.SaveChanges();
        }

        public List<T> getAll()
        {
            return _context.Set<T>().ToList();
        }

        public T getById(int Id)
        {
            return _context.Set<T>().Find(Id);
        }

        public void insert(T p)
        {
            _context.Add(p);
            _context.SaveChanges();
        }

        public List<T> List(Expression<Func<T, bool>> filter)
        {
            return _context.Set<T>().ToList();
        }

        public void update(T p)
        {
            _context.Update(p);
            _context.SaveChanges();
        }
    }
}
