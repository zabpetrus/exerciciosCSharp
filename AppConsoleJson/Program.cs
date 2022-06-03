using AppConsoleJson.sources;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AppConsoleJson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //periodoMaiorFluxoElevadorMaisFrequentado List<char>
            ReadJsonData readJsonData = new ReadJsonData("C:/input.json");
            Dictionary< int, int> listaElevadores = new Dictionary< int, int>();
            Dictionary<int, char> listaTurno = new Dictionary<int ,char >();


            JArray jArray = readJsonData.GetData();

            List<Elevator> elevadores = jArray.ToObject<List<Elevator>>();

            foreach (Elevator elevator in elevadores)
            {
                if (!listaElevadores.ContainsKey(elevator.andar))
                {
                    listaElevadores[elevator.andar] = 0;
                    listaTurno[elevator.andar] = elevator.turno;

                }
                else
                {
                    listaElevadores[elevator.andar] += 1;
                }
            }

            Dictionary<int,int> orderedByValue = new Dictionary<int ,int>();
            var myList = from entry in listaElevadores orderby entry.Value descending select entry;
            foreach(var item in myList)
            {
                orderedByValue[item.Key] = item.Value;
            }



            
            foreach(var item in orderedByValue)
            {
               
                Console.WriteLine(item);
            }



                Console.WriteLine();
        }
    }
}
