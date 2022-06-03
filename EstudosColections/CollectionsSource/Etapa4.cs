using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsSource
{
    public class Etapa4
    {
        public static void CriarPercorrerArray()
        {
            //direto
            int[] arryInteiros = new int[3]
            {
                4, 5, 6
            };

            int[] arryInteiros2 = new int[3];
            arryInteiros2[0] = 10;
            arryInteiros2[1] = 20;
            arryInteiros2[2] = 30;

            for(int i = 0; i < arryInteiros2.Length; i++)
            {
                //atalho: cw  + tab
                Console.Write(arryInteiros2[i] + "-");
            }

            Console.WriteLine();

            foreach (int item in arryInteiros)
            {
                Console.Write(item + " - ");
            }

        }
    }
}
