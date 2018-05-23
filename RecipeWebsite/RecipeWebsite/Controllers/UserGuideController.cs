using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PeopleCook.Controllers
{
    public class UserGuideController : Controller
    {
        // GET: UserGuide
        public ActionResult Index()
        {
            return View();
        }
        // GET: PrivacyPolicy
        public ActionResult PrivacyPolicy()
        {
            return View();
        }
    }
}