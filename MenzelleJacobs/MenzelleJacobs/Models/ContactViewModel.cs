using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MenzelleJacobs.Models
{
    public class ContactViewModel
    {
        [Required(ErrorMessage = "I'd love to know your name!")]
        public string Name { get; set; }
        [Required(ErrorMessage = "In order to send me an email I need your address please.")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }
        public bool Hire { get; set; }
        [Required(ErrorMessage = "What would you like to say to me?")]
        public string VisitorMessage { get; set; }
        public string Confirmation { get; set; }
    }
}
