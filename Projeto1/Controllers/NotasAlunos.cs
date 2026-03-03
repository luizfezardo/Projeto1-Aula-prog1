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

            double media = notas.Values.Average();
            double maiorNota = notas.Values.Max();
            double menorNota = notas.Values.Min();

            foreach (var aluno in notas)
            {
                if (aluno.Value >= 7)
                {
                    Console.WriteLine($"{aluno.Key} aprovado");
                }
                else
                {
                    Console.WriteLine($"{aluno.Key} reprovado");
                }
            }

            return View();
        }