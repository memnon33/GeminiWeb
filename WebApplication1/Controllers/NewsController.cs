using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class NewsController : Controller
    {
        //
        // GET: /News/
        public ActionResult Index()
        {
            ViewBag.Message = "News index";
            return View();
        }

        public ActionResult News()
        {
            ViewBag.Message = "News page";
            return View();
        }
	}
}