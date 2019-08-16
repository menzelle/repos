using MenzelleJacobs.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using MimeKit;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace MenzelleJacobs.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        


        [HttpPost]
        public async Task<IActionResult> ContactForm(ContactViewModel cvm)
        {
            ContactViewModel _contactViewModel = cvm;
            if (ModelState.IsValid)
            {
                _contactViewModel.Confirmation = "Your form has been submitted";

                var message = new MimeMessage();
                message.From.Add(new MailboxAddress("me", "menzelle@live.com"));
                message.To.Add(new MailboxAddress("me", "menzelle.jacobs@gmail.com"));
                message.Subject = "How you doin?";

                message.Body = new TextPart("plain")
                {
                    Text = @"Hey Alice,

What are you up to this weekend? Monica is throwing one of her parties on
Saturday and I was hoping you could make it.

Will you be my +1?

-- Joey
"
                };

            }
            else
            {
                _contactViewModel.Confirmation = "Please fix errors";

            }

            return RedirectToAction("Contact", "Home", _contactViewModel.Confirmation);


        }
    }
}
