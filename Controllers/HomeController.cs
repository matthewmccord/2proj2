using _2proj2.Models;
using _2proj2.Models.ViewModels;
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

        public HomeController(TimeFormContext form_context, TimeFormContext x)
        {
            FormContext = form_context;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult SignUp()
        {
            var slots = FormContext.slots
                .ToList();
            return View(slots);

        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpGet]
        public IActionResult TimeForm(int groupid)
        {
            //var x = new FormInfo
            //{
            //    time = 
            //}
            return View();
        }

        [HttpPost]
        public IActionResult TimeForm(FormInfo u)
        {
            if (ModelState.IsValid)
            {
                u.user.TimeId = u.time.TimeID;
                FormContext.Add(u.user);
                FormContext.SaveChanges();

                return View("Confirmation", u);
            }
            else
            {
                return View(u);
            }
        }

        public IActionResult test(int timeid)
        {
            var x = new FormInfo
            {
                time = FormContext.slots.Single(x => x.TimeID == timeid)
            };

            return View("TimeForm", x);
        }
            
        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
