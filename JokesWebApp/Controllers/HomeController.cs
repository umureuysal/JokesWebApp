using Jokes.Business.Concrete;
using Jokes.DataAccess.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace JokesWebApp.Controllers
{
    public class HomeController : Controller
    {
        JokeManager jokeManager = new JokeManager(new JokeRepository());
        Context context = new Context(); 
        public IActionResult Sakalar()
        {
            var sakalar = context.Jokes;
            return View(sakalar);
        }
    }
}
