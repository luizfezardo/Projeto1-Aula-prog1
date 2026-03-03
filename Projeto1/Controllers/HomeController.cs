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

        //-----------------------------------------------------------------------------------------------------------

        [HttpGet]
        public IActionResult Notas()
        {
            Dictionary<string, double> notas = new Dictionary<string, double>();

            notas.Add("João", 8.5);
            notas.Add("Maria", 9.0);
            notas.Add("Pedro", 7.5);
            notas.Add("Ana", 9.5);
            notas.Add("Lucas", 6.0);

            double soma = 0;
            double media = notas.Values.Average();
            double maiorNota = notas.Values.Max();
            double menorNota = notas.Values.Min();
            int reprovados = 0;
            int aprovados = 0;
            int recuperacao = 0;

            foreach (var aluno in notas)
            {
                double notaAtual = aluno.Value;

                soma += notaAtual;
                if
                    (notaAtual > 7.0)
                {
                    aprovados++;
                }
                else if
                    (notaAtual > 5.0 && notaAtual < 6.9)
                {
                    recuperacao++;
                }
                else if
                    (notaAtual < 5.0)
                {
                    recuperacao++;
                }

            }

            List<string> relatorio = new List<string>();
            relatorio.Add($"Média das notas: {media}");
            relatorio.Add($"Maior nota: {maiorNota}");
            relatorio.Add($"Menor nota: {menorNota}");
            relatorio.Add($"Quantidade de alunos reprovados: {reprovados}");
            relatorio.Add($"Quantidade de alunos aprovados: {aprovados}");
            relatorio.Add($"Quantidade de alunos em recuperação: {recuperacao}");


            return View("Notas", relatorio);
        }

        //--------- --------------------------------------------------------------------------------------------------




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
