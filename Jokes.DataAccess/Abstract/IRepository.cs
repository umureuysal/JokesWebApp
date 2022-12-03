using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Jokes.DataAccess.Abstract
{
    public interface IRepository<T> where T : class, new()
    {
        List<T> GetAll();
        List<T> GetList(Expression<Func<T, bool>> filter);
        T Get(Expression<Func<T, bool>> filter);
        void Insert (T item);
        void Update (T item);
        void Delete (T item);
    }
}
