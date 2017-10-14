using RazorPractice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RazorPractice.Controllers
{
    public class OrderController : Controller
    {
        public ActionResult CreateOrderAction(Order order)
        {
            return RedirectToAction("CreateOrderView");
        }

        // GET: OrderController
        public ActionResult CreateOrderView()
        {
            return View();
        }

        
    }
}