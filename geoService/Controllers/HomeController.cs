using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace geoService.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
<<<<<<< HEAD
            ViewBag.Message = "Modify this 1авыавыавtemplate to jump-start your ASP.NET MVC applicationааааааааааааа.";
=======
            ViewBag.Message = "Modify this 1авыавыавtemplate to jump-stааааааааааааааааааааart your ASP.NET MVC application.";
>>>>>>> 3a21a56f8e4acc237874411816088e9438751d1e

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
