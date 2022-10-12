using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;

namespace Lesson2.Controllers
{
    public class OgrenciController : Controller
    {
        public IActionResult OgrenciEkle()
        {
            return View();
        }

        public string OgrKaydet(string fname, string lname, string Onum)
        {
            string Msg = fname + lname + Onum;
            return Msg;
        }
    }
}
