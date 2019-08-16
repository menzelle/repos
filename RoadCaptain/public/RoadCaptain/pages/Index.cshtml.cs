using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;

namespace RoadCaptain.Pages
{
    public class IndexModel : PageModel
    {
        public string ApplicationId { get; set; }
        public string LocationId { get; set; }


        public IndexModel(IConfiguration configuration)
        {
            this.ApplicationId = configuration["AppSettings:ApplicationId"];
            this.LocationId = configuration["AppSettings:LocationId"];
        }
    }
}
