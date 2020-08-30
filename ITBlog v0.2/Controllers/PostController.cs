using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ITBlog_v0._2.Controllers
{
    public class PostController : Controller
    {
        // GET: Post
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult AllPost()
        {
            ViewBag.Message = "Tất cả bài viết.";
            return View();
        }
        public ActionResult ProgrammingPost()
        {
            ViewBag.Message = "Bài viết lập trình.";
            return View();
        }
    }
}