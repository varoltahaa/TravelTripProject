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
        public ActionResult Index()
        {
            var blogs = c.Blogs.ToList();
            return View(blogs);
        }
        BlogComment by = new BlogComment();
        public ActionResult BlogDetay(int id)
        {

            //var blogBul = c.Blogs.Where(x => x.Id == id).ToList();
            by.ValueOne = c.Blogs.Where(x => x.Id == id).ToList();
            by.ValueTwo = c.Comments.Where(x => x.BlogId == id).ToList();
            return View(by);
        }
    }
}