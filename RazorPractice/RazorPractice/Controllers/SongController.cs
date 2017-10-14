using RazorPractice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RazorPractice.Controllers
{
    public class SongController : Controller
    {
        //the Action
        public ActionResult AddSongAction(Song song)
        {
            //route the Action to the my view which is CreateSong
            return RedirectToAction("CreateSongView");
        }

        // GET: CreatSong
        //the controller make the action on this view - which is CreateSong-
        public ActionResult CreateSongView()
        {
            return View();
        }
        
    }
}