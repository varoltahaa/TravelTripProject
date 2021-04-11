using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProject.Models.Classes;

namespace TravelTripProject.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        Context c = new Context();
        BlogComment by = new BlogComment();
        public ActionResult Index()
        {
            //var blogs = c.Blogs.ToList();
            by.ValueOne = c.Blogs.ToList();
            by.ValueThree = c.Blogs.Take(5).ToList();
            return View(by);
        }
        public ActionResult BlogDetay(int id)
        {

            //var blogBul = c.Blogs.Where(x => x.Id == id).ToList();
            by.ValueOne = c.Blogs.Where(x => x.Id == id).ToList();
            by.ValueTwo = c.Comments.Where(x => x.BlogId == id).ToList();
            by.ValueThree = c.Blogs.Take(2).ToList();
            return View(by);
        }
        [HttpPost]
        public PartialViewResult Comment(Comment comment)
        {
            c.Comments.Add(comment);
            c.SaveChanges();
            return PartialView();
        }
        [HttpGet]
        public PartialViewResult Comment(int id)
        {
            ViewBag.value = id;
            return PartialView();
        }
    }
}