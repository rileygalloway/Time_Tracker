using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TimeTrackerUser.Models;

namespace TimeTrackerUser.Controllers
{
    public class HomeController : Controller
    {
        TimeTrackerEntities timetrackerDb = new TimeTrackerEntities();

        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            // this was put here to test whether db connection and schema mapping weas working correctly.
            // delete this and uncomment the line below the line below 
            var orgs = timetrackerDb.ServiceOrganizations.ToList();
            return View(orgs);

            //return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
