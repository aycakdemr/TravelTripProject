using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TravelTripProject.Controllers
{
    public class AboutController : Controller
    {
        // GET: About

        AboutManager aboutManager = new AboutManager(new EfAboutDal());
        public ActionResult Index()
        {
            var value = aboutManager.GetAll();
            return View(value);
        }
    }
}