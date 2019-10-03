using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppWithScheduler.Code;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

namespace AppWithScheduler.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Quote = QuoteOfTheDay.Current.Quote;
            ViewBag.Author = QuoteOfTheDay.Current.Author;

            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
