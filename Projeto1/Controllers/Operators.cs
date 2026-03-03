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
            xXx = xXx + yXy;


            //Operadores de incremento e decremento

            //podemos incrementar de forma original

            int luiz = x + 1;
            luiz = x++; //incrementando
            luiz = x--; //decrementa

            //no entanto tem outra forma de controla a precedencia de incremento ou decremento se eu desejar que a incrementação ocorra antes de qualquer outra operação, colocacamos os operadores antes da variavel
            luiz = ++luiz * 2;

            //operadores de comparação
            int num1 = 9;
            int num2 = 9;
            string resultado = string.Empty;

            if(num1 = num2)
            {
                resultado = "Iguais";
            }

            //também podemos atribuir uma comparação diretamente a uma variavel

            bool eIgual = (num1 == num2)?

            return View();
        }
    }
}
