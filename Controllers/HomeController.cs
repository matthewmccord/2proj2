using _2proj2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace _2proj2.Controllers
{
    public class HomeController : Controller
    {
        private TimeFormContext FormContext { get; set; }
        
        
        

        public HomeController(TimeFormContext form_context)
        {
            FormContext = form_context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpGet]
        public IActionResult TimeForm()
        {
            return View();
        }

        [HttpPost]
        public IActionResult TimeForm(User u)
        {
            if (ModelState.IsValid)
            {
                FormContext.Add(u);
                FormContext.SaveChanges();

                return View("Confirmation", u);
            }
            else
            {
                return View(u);
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
