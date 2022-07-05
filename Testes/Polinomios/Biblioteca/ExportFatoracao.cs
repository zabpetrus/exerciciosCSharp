using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class ExportFatoracao
    {
        public static Dictionary<int, int> exportar( string expression )
        {

            Dictionary<int, int> valoresecoeficientes = new Dictionary<int, int>();
            string[] signalsB = new string[] { "#", "*", "/" };

            try
            {
                var p = expression.Replace("+", "#+").Replace("-", "#-");
                var t = p.Split(signalsB, StringSplitOptions.RemoveEmptyEntries);

                foreach (var str in t)
                {

                    var calc = str.Trim().Split("x"); //Obtenho os numeros
                    var aux = calc[0].Replace(" ", "").Trim();

                    var valor = calc[0];
                    var coeficiente = "";
                    if (calc.Length > 1)
                    {
                        var coe = calc[1];
                        coeficiente = Regex.Match(coe, @"\d+").Value;
                        if (coeficiente == "") { coeficiente = "1"; }

                    }
                    else
                    {
                        coeficiente = "0";
                    }

                    int nvalor = 0;

                    //O que era pro parse fazer mas não faz

                    if (aux.Contains("+"))
                    {
                        nvalor = Int32.Parse(Regex.Match(valor, @"\d+").Value);
                    }
                    else if (aux.Contains("-"))
                    {
                        nvalor = (Int32.Parse(Regex.Match(valor, @"\d+").Value)) * (-1);
                    }
                    else
                    {
                        nvalor = Int32.Parse(valor);
                    }

                    int ncoeficiente = Int32.Parse(coeficiente);
                    valoresecoeficientes[ncoeficiente] = nvalor;

                }

            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }              

            return valoresecoeficientes;

        }

        public static void exibirDictionary(Dictionary<int, int> valoresecoeficientes )
        {
            foreach(var str in valoresecoeficientes)
            {
                Console.WriteLine("Coeficientes: " + str.Key + " Valores: " + str.Value);
            }
            Console.WriteLine();
        }
    }
}
