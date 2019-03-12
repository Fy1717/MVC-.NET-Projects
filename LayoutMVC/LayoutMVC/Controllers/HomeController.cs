using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LayoutMVC.Controllers
{
    public class HomeController : Controller
    {
        // ANASAYFA
        public ActionResult Anasayfa()
        {
            return View();
        }


        // İletişim
        public ActionResult Iletisim()
        {
            return View();
        }


        // Hakkımızda
        public ActionResult Hakkimizda()
        {
            return View();
        }
    }
}