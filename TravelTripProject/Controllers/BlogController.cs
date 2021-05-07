using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using EntityLayer.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TravelTripProject.Controllers
{
    public class BlogController : Controller
    {
        BlogManager blogManager = new BlogManager(new EfBlogDal());
        CommentManager commentManager = new CommentManager(new EfCommentDal());
        // GET: Blog
        BlogCommentDto dto = new BlogCommentDto();
        public ActionResult Index()
        {
            dto.Deger1 = blogManager.GetAll();
            dto.Deger3 = blogManager.GetAll().OrderByDescending(x => x.Id).Take(5).ToList();
            // var value = blogManager.GetAll();
            return View(dto);
        }
      
        public ActionResult BlogDetail(int id)
        {
            dto.Deger1 = blogManager.GetById(id);
            dto.Deger2 = commentManager.GetById(id);
          //  var value = blogManager.GetCommentByBlogId(id);
            return View(dto);
        }
     
        [HttpGet]
        public PartialViewResult ToComment(int id)
        {
            ViewBag.deger = id;
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult ToComment(Comment comment)
        {
            commentManager.Add(comment);
            Response.Redirect("/Blog/Index/");
            return PartialView();

        }

    }
}