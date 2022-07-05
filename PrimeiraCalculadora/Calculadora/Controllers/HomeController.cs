using Calculadora.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(double n1, double n2, string sinal)
        {
            double result = 0;            
            char m = char.Parse(sinal);
            switch(m)
            {
                case '+':
                    result = Calculador.Adicionar(n1, n2);
                    break;
                case '-':
                    result = Calculador.Subrair(n1, n2);
                    break;
                case '*':
                    result = Calculador.Multiplicar(n1, n2);
                    break;
                case '/':
                    result = Calculador.Dividir(n1, n2);
                    break;
            }
            ViewBag.Name = string.Format("Operação: {0} {1} {2} = {3}", n1, sinal, n2, result);
            return View();
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
