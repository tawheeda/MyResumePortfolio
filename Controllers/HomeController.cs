using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MyPortfolio.Models;

namespace MyPortfolio.Controllers
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
            var skills = new List<LanguageSkill>
            {
                new LanguageSkill { Language = "HTML", Proficiency = 90 },
                new LanguageSkill { Language = "CSS", Proficiency = 85 },
                new LanguageSkill { Language = "JavaScript", Proficiency = 75 },
                new LanguageSkill { Language = "C#", Proficiency = 80 },
                new LanguageSkill { Language = "SQL", Proficiency = 70 },
                new LanguageSkill { Language = "Python", Proficiency = 60 }
            };

            ViewBag.Skills = skills;
            return View();
        }
        public IActionResult Privacy()
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
