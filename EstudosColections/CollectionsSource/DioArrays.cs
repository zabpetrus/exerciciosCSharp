using System;

namespace CollectionsSource
{
    public class DioArrays
    { 
        public static void declaraArrays()
        {
            //Arrays são estruturas de dados que armazenam dados de um unico tipo
            int[] arrya1 = new int[4];  //capacidade 4 ou limite 4
            int[] arrya2 = new int[] { 42, 75, 74, 61 };
            string[] arrya3 = { "Jan", "Fev" }; //new string[4];

            //Disposição do array -> Indices
            var elemento = arrya2[0]; //posicao até n-1
            //modificando o valor 

            arrya2[0] = 45;
        }


        public static void declaraMatriz()
        {
            int[,] array = new int[4, 5]; //numero de linhas:4 .:. numero de colunas:5
            for(int i = 0; i < 4; i++)
            {
                for(int j = 0; j < 5; j++)
                {
                    Console.Write(" | ");
                    array[i, j] = 1 + ((i + j) ^ 2);
                    Console.Write(array[i, j]);
                    
                }
                Console.Write(" | ");
                Console.WriteLine();
            }
            int p = array[1, 1];
            Console.WriteLine("Valor [1,1]: " + p); 
        }
    }
}
