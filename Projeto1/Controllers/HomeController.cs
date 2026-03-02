using Microsoft.AspNetCore.Mvc;
using Projeto1.Models;
using System.Diagnostics;

namespace Projeto1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        
        [HttpGet]
        public IActionResult Variables()
        {

            string retorno = string.Empty;

            return View("Variables", retorno);
        }

        // -----------------------------------------------------------------------------------------------------------------------
        [HttpGet]
        public async Task<IActionResult> Numbers()
        {
            string retorno = string.Empty;

            retorno += $"Valor máximo para int: {int.MaxValue}<br/>";
            retorno += $"Valor mínimo para int: {int.MinValue}<br/>";
            retorno += $"Valor máximo para double: {double.MaxValue}<br/>";
            retorno += $"Valor mínimo para double: {double.MaxValue}<br/>";
            retorno += $"Valor máximo para decimal: {decimal.MaxValue}<br/>";
            retorno += $"Valor mínimo para decimal: {decimal.MinValue}<br/>";
            retorno += $"Valor máximo para long: {long.MaxValue}<br/>";
            retorno += $"Valor mínimo para long: {long.MinValue}<br/>";
            retorno += $"Valor máximo para float: {float.MaxValue}<br/>";
            retorno += $"Valor mínimo para float: {float.MinValue}<br/>";
            retorno += $"Valor máximo para byte: {byte.MaxValue}<br/>";
            retorno += $"Valor mínimo para byte: {byte.MinValue}<br/>";
            retorno += $"Valor máximo para short: {short.MaxValue}<br/>";
            retorno += $"Valor mínimo para short: {short.MinValue}<br/>";
            retorno += $"Valor máximo para sbyte: {sbyte.MaxValue}<br/>";
            retorno += $"Valor mínimo para sbyte: {sbyte.MinValue}<br/>";
            retorno += $"Valor máximo para uint: {uint.MaxValue}<br/>";
            retorno += $"Valor mínimo para uint: {uint.MinValue}<br/>";

            return View("Numbers", retorno);
        }

        // -----------------------------------------------------------------------------------------------------------

        [HttpGet]

        public async Task<IActionResult> Dictionary()
        {
            Dictionary<int, string> data = [];

            for (int i = 1; i <= 10; i++)
            {
                data.Add(i, $"Valor {i}");
            }

            return View("Dictionary", data);
        }











        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
