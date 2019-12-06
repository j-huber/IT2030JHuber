using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FinalProject_JasonHuber.Models;

namespace FinalProject_JasonHuber.Controllers
{
    public class HomeController : Controller
    {
        private FinalProject_JasonHuberDBContext db = new FinalProject_JasonHuberDBContext();

        private List<Event> GetEvents()
        {
            return db.Events.ToList();
        }
        public ActionResult Index()
        {
            var eventslist = GetEvents();
            return View(eventslist);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}