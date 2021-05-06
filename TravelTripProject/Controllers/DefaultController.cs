using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TravelTripProject.Controllers
{
    public class DefaultController : Controller
    {
        BlogManager blogManager = new BlogManager(new EfBlogDal());
        // GET: Default
        public ActionResult Index()
        {
            var value = blogManager.GetAll();
            return View(value);
        }
        public ActionResult About()
        {
            return View();
        }
        public PartialViewResult Partial1()
        {
            var value = blogManager.GetAll().OrderByDescending(x => x.Id).Take(3).ToList();
            return PartialView(value);
        }
        public PartialViewResult Partial2()
        {
            var value = blogManager.GetAll().OrderByDescending(x => x.Id).Take(10).ToList(); ;
            return PartialView(value);
        }
        public PartialViewResult Partial3()
        {
            var value = blogManager.GetAll().OrderByDescending(x => x.Id).Take(3).ToList(); ;
            return PartialView(value);
        }
        public PartialViewResult Partial4()
        {
            var value = blogManager.GetAll().Take(3).ToList(); ;
            return PartialView(value);
        }
    }
}