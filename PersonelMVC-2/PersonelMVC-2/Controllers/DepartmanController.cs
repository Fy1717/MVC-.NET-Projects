using PersonelMVC_2.Models;
using PersonelMVC_2.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PersonelMVC_2.Controllers
{
    public class DepartmanController : Controller
    {
        /*  
           
        BU İKİ YÖNTEMİ MECBUR KALMAYINCA KULLANMA      
          
        public ActionResult Detay(int id)
        {
            var departman = new Departman() { Id = id, Ad = "Bilgi İşlem" };
            ViewData["departman"] = departman;
            return View();
        }


        public ActionResult Detay(int id)
        {
            var departman = new Departman() { Id = id, Ad = "Bilgi İşlem" };
            ViewBag.Departman = departman;
            return View();
        }


       */



        public ActionResult Detay()
        {
            var departman = new Departman() {
                Id = 1, Ad = "Bilgi İşlem" 
            };

            var personeller = new List<Personel>()
            {
                new Personel(){ Ad = "FURKAN YILDIZ" },
                new Personel(){ Ad = "OĞUZHAN DEMİR" },
                new Personel(){ Ad = "ZAHİDE ÖZKAN" }

            };

            var model = new DepartmanDetayViewModel()
            {

                Departman   = departman,
                Personeller = personeller

            };

            return View(model);
        }


    }
}