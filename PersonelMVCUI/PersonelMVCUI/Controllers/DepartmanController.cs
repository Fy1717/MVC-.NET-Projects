using PersonelMVCUI.Models.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PersonelMVCUI.Controllers
{
    public class DepartmanController : Controller
    {
        //PersonelDbEntities2 db = new PersonelDbEntities2();
        
        public ActionResult Index()
        {
            var model = db.Departmen.ToList(); // Buraya yanlışlıkla Departmen yazmışsın
            return View(model);
        }

        [HttpGet] 
        public ActionResult Yeni()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Yeni(Departman departman)
        {
            db.Departmen.Add(departman);
            db.SaveChanges();
            return RedirectToAction("Index", "Departman");
        }
    }
}