using Biblioteca;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Polinomios
{
    internal class Program
    {
        static void Main(string[] args)
        {       
          
            Console.WriteLine("Entre com a equação A: ");
            string expressaoA = Console.ReadLine();

            Console.WriteLine("Entre com a equação B: ");
            string expressaoB = Console.ReadLine();

            Dictionary<int, int> valoresA = ExportFatoracao.exportar(expressaoA);
            ExportFatoracao.exibirDictionary(valoresA);

            Dictionary<int, int> valoresB = ExportFatoracao.exportar(expressaoB);
            ExportFatoracao.exibirDictionary(valoresB);


        

        }
    }
}
