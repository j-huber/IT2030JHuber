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

        //public ActionResult LastMinuteDeal()
        // {
         //    var event = GetLastMinuteDeal();
         //    return PartialView("_LastMinuteDeal",event);
         //}

        // private List<Event> GetLastMinuteDeal()
       // {
         //   var event = db.Event.Orderby(a=> Guid.NewGuid(()).First();
         //    return Event;
        // }

      //public ActionResult EventSearch(string q)
        //{
       //     var event = getEvents(q);
       //     return PartialViewResult(Events);
      //  }

   // private List<Event> getEvents(string searchString
    //{
   //     return db.Event.Where(a=>a.)
        
   // }

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