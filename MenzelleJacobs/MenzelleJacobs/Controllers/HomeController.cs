using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MenzelleJacobs.Models;

namespace MenzelleJacobs.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult MyExperience()
        {
            ViewData["Message"] = "Your application description page.";

            MyExperienceViewModel myExperienceViewModel = new MyExperienceViewModel()
            {
                Title = "My Work Experience",
                WorkExperience = ""

            };

            return View("Pages",myExperienceViewModel);
        }


        public IActionResult Contact()
        {
            ContactViewModel cvm = new ContactViewModel();
            return View("Pages",cvm);
        }

        public IActionResult Pages()
        {
            return View("Pages");
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
