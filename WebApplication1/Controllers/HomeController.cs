using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "About Gemini Cheer";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Gemini Cheer contact page.";

            return View();
        }
        public ActionResult MiniGem()
        {
            ViewBag.Message = "Gemini minigems.";

            return View();
        }
        public ActionResult JuniorA()
        {
            ViewBag.Message = "Gemini Junior As.";

            return View();
        }
        public ActionResult JuniorB()
        {
            ViewBag.Message = "Gemini Junior Bs.";

            return View();
        }
        public ActionResult Seniors()
        {
            ViewBag.Message = "Gemini Seniors";

            return View();
        }
        public ActionResult Masters()
        {
            ViewBag.Message = "Gemini Masters";

            return View();
        }
    }
}