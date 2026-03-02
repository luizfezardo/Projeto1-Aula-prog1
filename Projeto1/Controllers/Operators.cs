using Microsoft.AspNetCore.Mvc;

namespace Projeto1.Controllers
{
    public class Operators : Controller
    {
        public IActionResult Index()
        {
            int y = -10; // = é operador unario de atribuição
            int x = 2;
            int z = y - x;

            //precedencia
            int xx = 10 - 20 * 10;

            // C# já conhece a regra de precedencia dos operadores aritimeticos 
            //No entanto, se eu desejar manipular a ordem das operações, podemos usar {}

            int yy = (10 - 20) * 10;

            //operadores de composição
            int xXx = 10;
            int yXy = 20;
            xXx += yXy;

            return View();
        }
    }
}
