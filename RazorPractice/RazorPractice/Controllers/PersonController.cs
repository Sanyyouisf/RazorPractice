using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RazorPractice.Controllers
{
    public class PersonController : Controller
    {
        public ActionResult CreatePersonAction (PersonController person)
        {
            return RedirectToAction ("CreatePersonView");
        }

        // GET: Person
        public ActionResult CreatePersonView()
        {
            return View();
        }
    }
}