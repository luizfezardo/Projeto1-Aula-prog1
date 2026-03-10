using Microsoft.AspNetCore.Mvc;

namespace Projeto1.Controllers
{
    public class FlorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
