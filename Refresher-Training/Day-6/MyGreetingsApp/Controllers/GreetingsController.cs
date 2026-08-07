using Microsoft.AspNetCore.Mvc;
using MyGreetingsApp.Models;

namespace MyGreetingsApp.Controllers
{
    public class GreetingsController : Controller
    {
        private readonly IConfiguration configuration; 

        public GreetingsController(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public IActionResult Index()
        {
            return View(new GreetingModel()); 
        }

        [HttpPost]
        public IActionResult ShowGreeting()
        {
            GreetingModel model = new GreetingModel();
            model.Message = configuration["GreetingMessage"];

            return View("Index", model);
        }
    }
}