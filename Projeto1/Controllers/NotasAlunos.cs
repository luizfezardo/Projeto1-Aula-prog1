using Microsoft.AspNetCore.Mvc;

namespace Projeto1.Controllers
{
    public class NotasAlunos : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
