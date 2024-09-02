using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using project_StudentsMVC.Models;


namespace project_StudentsMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact page - Academy of Learning";

            return View();
        }
        public ActionResult Instructor(int id)
        {
            ViewBag.Id = id;

            Instructor dayTimeInstructor = new Instructor
            {
                Id = 1,
                FirstName = "Erik",
                LastName = "Gross"
            };

            return View(dayTimeInstructor);
        }
        public ActionResult Instructors()
        {
            List<Instructor> instructors = new List<Instructor>
                new Instructor
                {
                    Id = 1,
                    FirstName = "Obay",
                    LastName = "Sweid"
                },
                new Instructor
                {
                    Id = 2,
                    FirstName = "Dave",
                    LastName = "Potter"
                },
                new Instructor
                {
                    Id = 3,
                    FirstName = "Ethan",
                    LastName = "Null"
                }

        };
        return View(instructors);
    }
}