using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppConsoleJson.sources
{
    public class Exibidor
    {
        public static List<char> elevadorMaisFrequentado()
        {
            ReadJsonData readJsonData = new ReadJsonData("C:/input.json");
            Dictionary<char, int> keyValuePairs = new Dictionary<char, int>();
            JArray jArray = readJsonData.GetData();
            List<Elevator> elevadores = jArray.ToObject<List<Elevator>>();
            foreach (Elevator elevator in elevadores)
            {
                if (!keyValuePairs.ContainsKey(elevator.elevador))
                {
                    keyValuePairs[elevator.elevador] = 0;
                }
                else
                {
                    keyValuePairs[elevator.elevador] += 1;
                }
            }

            List<char> keys = new List<char>();

            var myList = from entry in keyValuePairs orderby entry.Value ascending select entry;

            foreach (var value in myList)
            {
                keys.Add(value.Key);
            }

            return keys;

        }


        public static List<int> andarMenosUtilizado()
        {
            ReadJsonData readJsonData = new ReadJsonData("C:/input.json");
            Dictionary<int, int> keyValuePairs = new Dictionary<int, int>();
            JArray jArray = readJsonData.GetData();
            List<Elevator> elevadores = jArray.ToObject<List<Elevator>>();
            foreach (Elevator elevator in elevadores)
            {
                if (!keyValuePairs.ContainsKey(elevator.andar))
                {
                    keyValuePairs[elevator.andar] = 0;
                }
                else
                {
                    keyValuePairs[elevator.andar] += 1;
                }
            }


            List<int> menos = new List<int>();

            var myList = from entry in keyValuePairs orderby entry.Value ascending select entry;

            foreach (var value in myList)
            {
                menos.Add(value.Key);
            }

            return menos;
        }




    }
}
