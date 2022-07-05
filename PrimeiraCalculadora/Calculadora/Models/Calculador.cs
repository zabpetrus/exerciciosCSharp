using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora.Models
{
    public class Calculador
    {
        public static double Adicionar(double a, double b)
        {
            return a + b;
        }

        public static double Subrair(double a, double b)
        {
            return a - b;
        }

        public static double Multiplicar(double a, double b)
        {
            return a * b;
        }

        public static double Dividir(double a, double b)
        {
            try
            {
                return a / b;

            }catch(DivideByZeroException e)
            {
                Console.WriteLine("Divisão por zero" + e);
                return 1;
            }                   }

    }
}
