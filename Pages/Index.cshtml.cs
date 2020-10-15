using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace razor.Pages
{
    public class IndexModel : PageModel
    {
        public double _tip;
        private double tip2;
        public double Tip
        {
            get
            {
                return tip2;
            }
            set
            {
                tip2 = value;
            }
        }

        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
        public void OnPost()
        {
            double amount = double.Parse(Request.Form["amount"]);
            double tip = double.Parse(Request.Form["tip"]);
            int number = Int32.Parse(Request.Form["no"]);
            double tipPerPerson = (amount * tip) / (100 * number);
            ViewData["tipPerson"] = tipPerPerson;
            _tip = tipPerPerson;
            Tip = tipPerPerson;


        }
    }
}
