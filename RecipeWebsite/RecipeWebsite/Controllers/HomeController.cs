using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RecipeWebsite.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "All about food.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Address, email and phone.";

            return View();
        }
    }
}