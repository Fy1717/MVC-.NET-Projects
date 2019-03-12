using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PersonelMVCUI2.Models.EntityFramework;
using PersonelMVCUI2.ViewModels;

namespace PersonelMVCUI2.Controllers
{
    public class PersonelController : Controller
    {

        PersonelDbEntities1 db = new PersonelDbEntities1();

        public ActionResult Index()
        {
            var model = db.Personel.ToList();
            return View(model);
        }


        public ActionResult Yeni()
        {
            var model = new PersonelFormViewModel()
            {
                Departmanlar = db.Departman.ToList(),
                Personel = new Personel()
            };
            return View("PersonelForm", model);
        }           


        [ValidateAntiForgeryToken]
        public ActionResult Kaydet(Personel personel)
        {
            if (!ModelState.IsValid)
            {
                var model = new PersonelFormViewModel()
                {
                    Departmanlar = db.Departman.ToList(),
                    Personel = personel
                };

                return View("PersonelForm",model);
            }

            if (personel.Id == 0)
            {
                db.Personel.Add(personel);
            }
            else
            {
                db.Entry(personel).State = System.Data.Entity.EntityState.Modified;

            }
            db.SaveChanges();
            return RedirectToAction("Index");

        }

        public ActionResult Guncelle (int id)
        {
            var model = new PersonelFormViewModel()
            {
                Departmanlar = db.Departman.ToList(),
                Personel = db.Personel.Find(id)
            };
            return View("PersonelForm", model);

        }

        public ActionResult Sil (int id)
        {
            var silinecekPersonel = db.Personel.Find(id);

            if(silinecekPersonel == null)
            {
                return HttpNotFound();
            }

            db.Personel.Remove(silinecekPersonel);
            db.SaveChanges();
            return RedirectToAction("Index");

        }

    }
}

    