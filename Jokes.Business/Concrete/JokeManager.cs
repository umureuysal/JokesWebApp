using Jokes.Business.Abstract;
using Jokes.DataAccess.Abstract;
using Jokes.Entity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jokes.Business.Concrete
{
    public class JokeManager : IJokeService
    {
        public IJokeDal _jokeDal;

        public JokeManager(IJokeDal jokeDal)
        {
            _jokeDal = jokeDal;
        }

        public void Delete(Joke joke)
        {
            _jokeDal.Delete(joke);
        }

        public List<Joke> GetAll()
        {
            return _jokeDal.GetAll();
        }

        public Joke GetbyId(int id)
        {
            return _jokeDal.Get(x=>x.ID== id);
        }

        public void Insert(Joke joke)
        {
            _jokeDal.Insert(joke);
        }

        public void Update(Joke joke)
        {
            _jokeDal.Update(joke);
        }
    }
}
