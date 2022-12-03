using Jokes.Entity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Jokes.Business.Abstract
{
    public interface IJokeService
    {
        List<Joke> GetAll();
        Joke GetbyId(int id);
        void Insert(Joke joke);
        void Update(Joke joke);
        void Delete(Joke joke);
    }
}
