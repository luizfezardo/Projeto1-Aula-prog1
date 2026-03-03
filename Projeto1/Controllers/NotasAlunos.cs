using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.Eventing.Reader;
using System.Security.Cryptography.X509Certificates;

namespace Projeto1.Controllers
{
    public class NotasAlunos : Controller
    {
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


            return View();
        }
    }
}