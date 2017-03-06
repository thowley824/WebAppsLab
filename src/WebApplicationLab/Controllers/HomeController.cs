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

        public IActionResult ShowPerson(Person person)
        {

            ViewData["Heading"] = "Personal Information";


            Person student = person;
            ViewData["Name"] = student.FirstName + " " + student.LastName;
            ViewData["Birthday"] = student.Birthday;
            DateTime birthday = DateTime.Parse(student.Birthday);
            if(DateTime.Now.DayOfYear - birthday.DayOfYear > 0 || DateTime.Now.Year == birthday.Year)
            {
                student.Age = DateTime.Now.Date.Year - birthday.Year;
            }
            else
            {
                student.Age = DateTime.Now.Date.Year - birthday.Year - 1;
            }
            ViewData["Age"] = student.Age;

            return View();
        }

        public IActionResult AddPerson()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddPerson(Person person)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("ShowPerson", person);
            }
            else
            {
                return View(person);
            }
        }
    }
}
