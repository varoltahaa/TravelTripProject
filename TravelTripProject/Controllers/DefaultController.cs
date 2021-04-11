using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProject.Models.Classes;
using TravelTripProject.Controllers;

namespace TravelTripProject.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        Context c = new Context();
        public ActionResult Index()
        {
            var values = c.Blogs.Take(4).ToList();
            return View(values);
        }

        public ActionResult About()
        {
            return View();
        }
        public PartialViewResult PartialOne()
        {
            var values = c.Blogs.OrderByDescending(x => x.Id).Take(2).ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialTwo()
        {
            var values = c.Blogs.Where(x => x.Id == 1).ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialThree()
        {
            var values = c.Blogs.Take(10).ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialFour()
        {
            var values = c.Blogs.Take(3).ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialFive()
        {
            var values = c.Blogs.Take(3).OrderByDescending(x=> x.Id).ToList();
            return PartialView(values);
        }

    }
}