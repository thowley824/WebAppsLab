using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplicationLab.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            DateTime today = (DateTime.Now);

            int hour = today.Hour;

            if (hour < 12)
            {
                ViewData["ProperGreeting"] = "Good Morning!";
            }
            else if (hour >= 12 && hour <= 18)
            {
                ViewData["ProperGreeting"] = "Good Afternoon!";
            }
            else
            {
                ViewData["ProperGreeting"] = "Good Evening!";
            }

            ViewData["Time"] = today.ToString("t");

            ViewData["Day"] = today.DayOfWeek;

            ViewData["Date"] = today.ToString("D");

            ViewData["Countdown"] = 365 - today.DayOfYear;

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

        public ActionResult ShowPerson()
        {
            ViewData["Heading"] = "Personal Information";

            var student = new Person();
            student.FirstName = "Thomas";
            student.LastName = "Howley";
            student.Birthday = new DateTime(1988, 12, 7);

            ViewData["Name"] = student.FirstName + " " + student.LastName;
            ViewData["Birthday"] = student.Birthday;
            ViewData["Age"] = student.Age;

            return View();
        }
    }
}
