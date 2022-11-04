using Lesson4.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Lesson4.Controllers
{
    public class OgrenciController : Controller
    {
        private List<Ogrenci> _ogrenci = new();

        public OgrenciController()
        {
            _ogrenci = new List<Ogrenci>();
        }
        public IActionResult Index()
        {
            ViewBag.SehirKod = new List<SelectListItem>
            {
                new SelectListItem { Value = "06", Text = "Ankara" },
                new SelectListItem { Value = "34", Text = "İstanbul" },
                new SelectListItem { Value = "35", Text = "İzmir" },
                new SelectListItem { Value = "54", Text = "Sakarya" },
            };
            return View();
        }
        public IActionResult Index2()
        {
            return View();
        }

   
        public IActionResult OgrKaydet(Ogrenci ogrenci)

        {
            _ogrenci.Add(ogrenci);
            if (ModelState.IsValid)
            {
                return View(_ogrenci);
            }
            else
            {
                return View("Hata");
            }

        }

        public IActionResult Edit()
        {
            return View();
        }

        public IActionResult Delete()
        {
            return View();
        }
        public IActionResult OgrKaydetPost()
        {

            return View();
        }

        public IActionResult User()
        {
            return View();
        }
    }
}
