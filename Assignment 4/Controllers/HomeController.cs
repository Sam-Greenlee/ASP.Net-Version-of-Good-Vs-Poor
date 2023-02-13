using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Assignment_4.Models;

namespace Assignment_4.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Analysis()
        {
            return View();
        }

        public IActionResult GoodWebsite()
        {
            return View();
        }

        public IActionResult PoorWebsite()
        {
            return View();
        }

        public IActionResult Registration(Registrations registration)
        {
            if (ModelState.IsValid)
            {
                Repository.AddRegistration(registration);

                return View("Thanks", registration);
            }
            else
            {
                //There is a validation error
                return View();
            }
        }

        public IActionResult ListRegistrations()
        {
            return View(Repository.Registrations.Where(r => r.WillAttend == true));

        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }



    }
}
