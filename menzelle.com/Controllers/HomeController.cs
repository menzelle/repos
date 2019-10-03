using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using menzelle.com.Models;

namespace menzelle.com.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Testing()
        {
            return View();
        }

        public IActionResult TechnicalSkills()
        {
            return View();
        }
      
        public IActionResult Projects()
        {
            return View();
        }

        public IActionResult DegreesAndCerts()
        {
            return View();
        }

        public IActionResult Qualifications()
        {
            return View();
        }

        public IActionResult ContactMe()
        {
            return View();
        }

        public IActionResult AboutMe()
        {
            return View();
        }

        public IActionResult Resume()
        {
            return View();
        }
        public IActionResult LayoutGrid()
        {
            return View();
        }
    }
}
