using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Biblioteca
{
    public class Fatoracao
    {
        public static void exibir()
        {
            char[] signalsB = new char[] { '+', '-', '*', '/' };
            string expression = "12x^5 + 15x^4 + 1";

            try
            {
                var t = expression.Split(signalsB);
                foreach (var str in t)
                {

                    var calc = str.Trim().Split("x"); //Obtenho os numeros
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

                    Console.WriteLine("Valor: " + valor + " Coeficiente: " + coeficiente);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }                 

        }

        public static void exibir2()
        {
            string[] signalsB = new string[] { "#", "*", "/" };
            string expression = "12x^5 + 15x^4 - 1";

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

                    var nvalor = 0;

                    //O que era pro parse fazer mas não faz
                    if (aux.Contains("+"))
                    {
                        nvalor = Int32.Parse(  Regex.Match(valor, @"\d+").Value );
                    }                   
                    else if (aux.Contains("-"))
                    {
                        nvalor = ( Int32.Parse(Regex.Match(valor, @"\d+").Value)) * (-1);
                    }
                    else
                    {
                        nvalor = Int32.Parse(valor);
                    }
                        
                    

                    int ncoeficiente = Int32.Parse(coeficiente);    
                    Console.WriteLine("Valor: " + nvalor + " Coeficiente: " + ncoeficiente);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
