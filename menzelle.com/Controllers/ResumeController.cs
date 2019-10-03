using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using menzelle.com.Models;
using Microsoft.AspNetCore.Mvc;

namespace menzelle.com.Controllers
{
    public class ResumeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public ResumeElementViewModel TechnicalSkills()
        {
            ResumeElementViewModel viewModel = new ResumeElementViewModel()
            {
                Title = "Title",
                Content = "content"
            };
            return viewModel;
        }
    }
}