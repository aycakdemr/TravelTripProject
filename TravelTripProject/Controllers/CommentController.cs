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
    public class CommentController : Controller
    {
        CommentManager CommentManager = new CommentManager(new EfCommentDal());
        // GET: Comment
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ListComment(Comment comment)
        {
            var value = CommentManager.GetAll();
            return View(value);
        }
        public ActionResult DeleteComment(int id)
        {
            CommentManager.Delete(id);
            return RedirectToAction("ListComment");
        }
        public ActionResult GetComment(int id)
        {
            var value = CommentManager.GetComment(id);
            return View("GetComment", value);

        }
        public ActionResult UpdateComment(Comment comment)
        {
            CommentManager.Update(comment);
            return RedirectToAction("ListComment");
        }
    }
}