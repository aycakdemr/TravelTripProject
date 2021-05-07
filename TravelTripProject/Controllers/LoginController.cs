using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace TravelTripProject.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login

        AdminManager adminManager = new AdminManager(new EfAdminDal());
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Admin admin)
        {
            var info = adminManager.Auth(admin);
            if (info)
            {
                FormsAuthentication.SetAuthCookie(admin.User, false);
                Session["User"] = admin.User.ToString();
                return RedirectToAction("Index", "Admin");
            }
            else
            {
                return View();
            }
            
        }
        public ActionResult LogOut(Admin admin)
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login", "Login");
        
        }
    }
}