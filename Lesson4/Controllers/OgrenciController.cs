using Lesson4.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Lesson4.Controllers
{
    public class OgrenciController : Controller
    {
        static List<Ogrenci> ogrenciler=new List<Ogrenci>();
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
            return View();
        }
    }
}
