﻿using Jokes.DataAccess.Abstract;
using Jokes.Entity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jokes.DataAccess.Concrete
{
    public class JokeRepository:GenericRepository<Joke>, IJokeDal
    {
    }
}
