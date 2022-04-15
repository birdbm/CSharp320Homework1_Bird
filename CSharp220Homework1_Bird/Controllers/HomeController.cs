using CSharp220Homework1_Bird.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CSharp220Homework1_Bird.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult BirthdayCardGenerator()
        {
            return View();
        }

        [HttpPost]
        public IActionResult BirthdayCardGenerator(BirthdayCard birthdayCard)
        {
            if(!ModelState.IsValid)
            {
                return View();
            }
            return View("BirthdayCardConfirmation",birthdayCard);
        }

        public IActionResult BirthdayCardConfirmation()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}