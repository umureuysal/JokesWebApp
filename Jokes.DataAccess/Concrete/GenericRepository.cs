using Jokes.DataAccess.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Jokes.DataAccess.Abstract
{
    public class GenericRepository<T>:IRepository<T> where T : class, new()
    {
        Context context = new Context();
        DbSet<T> _object;

        public GenericRepository()
        {
            _object = context.Set<T>();
        }

        public void Delete(T item)
        {
            _object.Remove(item);
            context.SaveChanges();
        }

        public T Get(Expression<Func<T, bool>> filter)
        {
            return _object.SingleOrDefault(filter);
        }

        public List<T> GetAll()
        {
            return _object.ToList();
        }

        public List<T> GetList(Expression<Func<T, bool>> filter)
        {
            return _object.Where(filter).ToList();
        }

        public void Insert(T item)
        {
            _object.Add(item);
            context.SaveChanges();
        }

        public void Update(T item)
        {
            var updatedentity = context.Entry(item);
            updatedentity.State=EntityState.Modified;
            context.SaveChanges();
        }
    }
}
