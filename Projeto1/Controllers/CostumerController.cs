using Microsoft.AspNetCore.Mvc;
using Projeto1.Models;

namespace Projeto1.Controllers
{
    public class CostumerController : Controller
    {
        public IActionResult Index()
        {
            Costumer costumer = new Costumer();


            return View();
        }
    }
}
