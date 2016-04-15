using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspnetMixApplication.Areas.MvcArea.Controllers
{
    public class TestController : Controller
    {
        // GET: MvcArea/Test
        public ActionResult Index()
        {
            ViewData["Message"] = "This is ASP.NET MVC!";
            return View();
        }
    }
}