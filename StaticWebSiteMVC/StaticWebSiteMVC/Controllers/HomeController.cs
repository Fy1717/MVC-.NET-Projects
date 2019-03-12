using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StaticWebSiteMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [Route("hakkimda")]
        public ActionResult Hakkimda()
        {
            return View();
        }

        [Route("yazilarim")]
        public ActionResult Yazilarim()
        {
            return View();
        }

        [Route("iletişim")]
        public ActionResult Iletisim()
        {
            return View();
        }
    }
}