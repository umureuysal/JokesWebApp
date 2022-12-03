﻿using Jokes.Entity.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jokes.DataAccess.Concrete
{
    public class Context:DbContext
    {
        public DbSet<Joke> Jokes { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
