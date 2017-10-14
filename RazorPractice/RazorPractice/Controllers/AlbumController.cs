using RazorPractice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RazorPractice.Controllers
{
    public class AlbumController : Controller
    {
        public ActionResult AddAlbumAction(Album album)
        {
            return RedirectToAction("AlbumView");
        }
        // GET: Album
        public ActionResult AlbumView()
        {
            return View();
        }
    }
}