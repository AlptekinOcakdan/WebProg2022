using Microsoft.AspNetCore.Mvc;

namespace Lesson1.Controllers
{
    public class PersonelController : Controller
    {
        public IActionResult Goster()
        {
            return View();
        }
    }
}
