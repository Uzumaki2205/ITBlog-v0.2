using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ITBlog_v0._2.Controllers
{
    public class RecentlyController : Controller
    {
        // GET: Recently
        public ActionResult Index()
        {
            return View();
        }
    }
}