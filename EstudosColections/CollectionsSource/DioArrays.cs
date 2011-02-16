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
    }
}
