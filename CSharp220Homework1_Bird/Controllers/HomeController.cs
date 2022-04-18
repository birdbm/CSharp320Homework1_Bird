using Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Controllers
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
    }
}