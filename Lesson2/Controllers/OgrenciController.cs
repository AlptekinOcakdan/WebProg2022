using Lesson2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;

namespace Lesson2.Controllers
{
    public class OgrenciController : Controller
    { 
        static List<Ogrenci> ogrenciler = new List<Ogrenci>();
        public IActionResult OgrenciEkle()
        {
            return View();
        }
       

        
        [HttpPost]
        public IActionResult OgrKaydet(OgrenciViewModel ogr)
        {
            return View(ogr);
        }

        public IActionResult OgrKaydet4(OgrenciViewModel ogr)
        {
            ogrenciler.Add(ogr);
            return RedirectToAction()
        }
    }
}
