using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProject.Models.Classes;

namespace TravelTripProject.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        Context c = new Context();
        [Authorize]
        public ActionResult Index()
        {
            var values = c.Blogs.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult NewBlog()
        {
            return View();
        }
        [HttpPost]
        public ActionResult NewBlog(Blog blog)
        {
            c.Blogs.Add(blog);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DeleteBlog(int id)
        {
            var value = c.Blogs.Find(id);
            c.Blogs.Remove(value);
            c.SaveChanges();
            return RedirectToAction("Index"); 
        }
        public ActionResult GetBlog(int id)
        {
            var value = c.Blogs.Find(id);
            return View("GetBlog",value);
        }
        public ActionResult UpdateBlog(Blog blog)
        {
            var value = c.Blogs.Find(blog.Id);
            value.Explanation = blog.Explanation;
            value.Title = blog.Title;
            value.BlokImage = blog.BlokImage;
            value.History = blog.History;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult ListComment()
        {
            var value = c.Comments.ToList();
            return View(value);
        }
        public ActionResult DeleteComment(int id)
        {
            var value = c.Comments.Find(id);
            c.Comments.Remove(value);
            c.SaveChanges();
            return RedirectToAction("ListComment");
        }
        public ActionResult GetComment(int id)
        {
            var value = c.Comments.Find(id);
            return View("GetComment", value);
        }
        public ActionResult UpdateComment(Comment comment)
        {
            var value = c.Comments.Find(comment.Id);
            value.UserName = comment.UserName;
            value.Mail = comment.Mail;
            value.Comments = comment.Comments;
            c.SaveChanges();
            return RedirectToAction("ListComment");
        }

    }
}