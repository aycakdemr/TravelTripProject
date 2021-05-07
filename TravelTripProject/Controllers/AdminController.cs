using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TravelTripProject.Controllers
{
    public class AdminController : Controller
    {
        BlogManager blogManager = new BlogManager(new EfBlogDal());
        
        // GET: Admin
        [Authorize]
        public ActionResult Index()
        {
            var value = blogManager.GetAll();
            return View(value);
        }
        [HttpGet]
        public ActionResult AddBlog()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddBlog(Blog blog)
        {
            blogManager.Add(blog);
            return RedirectToAction("Index");
        }
        public ActionResult DeleteBlog(int id)
        {
            blogManager.Delete(id);
            return RedirectToAction("Index");
        }
        public ActionResult GetBlog(int id)
        {
           var value= blogManager.GetBlog(id);
           return View("GetBlog", value);

        }
        public ActionResult UpdateBlog(Blog blog)
        {
            blogManager.Update(blog);
            return RedirectToAction("Index");
        }
        
    }
}