using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class TentandoOutraCoisa
    {
        public static void tentativa1()
        {
            String[] expressions = { "16 + 21", "31 * 3", "28 / 3",
                       "42 - 18", "12 * 7",
                       "2, 4, 6, 8" };
            String pattern = @"(\d+)\s+([-+*/])\s+(\d+)";

            foreach (string expression in expressions)
            {
                foreach (System.Text.RegularExpressions.Match m in
                System.Text.RegularExpressions.Regex.Matches(expression, pattern))
                {
                    int value1 = Int32.Parse(m.Groups[1].Value);
                    int value2 = Int32.Parse(m.Groups[3].Value);
                    switch (m.Groups[2].Value)
                    {
                        case "+":
                            Console.WriteLine("{0} = {1}", m.Value, value1 + value2);
                            break;
                        case "-":
                            Console.WriteLine("{0} = {1}", m.Value, value1 - value2);
                            break;
                        case "*":
                            Console.WriteLine("{0} = {1}", m.Value, value1 * value2);
                            break;
                        case "/":
                            Console.WriteLine("{0} = {1:N2}", m.Value, value1 / value2);
                            break;
                    }
                }
            }

          
        }
    }
}
