using Lesson5.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Lesson5.Controllers
{
    public class OgrenciController : Controller
    {
        private static List<Ogrenci> ogrenciler = new List<Ogrenci>();    
        // GET: OgrenciController
        public ActionResult Index()
        {
            return View();
        }

        // GET: OgrenciController/Details/5
        public ActionResult Details(int id)
        {
            Ogrenci o = new Ogrenci();
            foreach (var ogrenci in ogrenciler)
            {
                if (ogrenci.OgrNo==id)
                {
                    o = ogrenci;
                }
            }
            return View(o);
        }

        // GET: OgrenciController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: OgrenciController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Ogrenci ogr)
        {
            if (ModelState.IsValid)
            {
                ogrenciler.Add(ogr);
                return RedirectToAction("OgrList");
            }
            else
            {
                return View("Hata");
            }
            
        }

        // GET: OgrenciController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }
        public ActionResult OgrList(int id)
        {
            return View(ogrenciler);
        }

        // POST: OgrenciController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: OgrenciController/Delete/5
        public ActionResult Delete(int id)
        {
            Ogrenci o = new Ogrenci();
            foreach (var ogrenci in ogrenciler)
            {
                if (ogrenci.OgrNo == id)
                {
                    o = ogrenci;
                    break;
                }
            }
            o = ogrenciler.Find(x => x.OgrNo == id);
            ogrenciler.Remove(o);
            
            return RedirectToAction("OgrList");
        }

        // POST: OgrenciController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
