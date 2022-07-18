using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViacaoCalango.Domain.Entity
{
    public class Onibus
    {
        public int Id { get; set; }
        public int CapMax { get; set; }
        public int QtdPassageiros { get; set; }
        public string TipoPoltrona { get; set; }
        public string[,] Rota { get; set; }

        public Onibus(int id, int max, int vagas, string tipo, string[,] rota)
        {
            Id = id;
            CapMax = max;
            QtdPassageiros = vagas;
            TipoPoltrona = tipo;
            Rota = rota;
        }

        public string BuscaRota(string inicio, string fim, string[,] rota)
        {
            int i = 0;
            int j = 0;
            foreach (var v in rota)
            {
                if (v == inicio)
                {

                    //string r = rota[j, 1];

                    foreach (var y in rota)
                    {
                        if (y == fim)
                        {
                            i++;
                            string r = rota[j, 1];
                            j++;
                            //return v + "-" + y;
                            return "horaSaida: " + r + " horaChegada: " + rota[i, 1];
                        }
                    }

                }
            }

            return "Não encontrado";
        }

        public string LOnibus(string inicio, string fim, int vagas, string[,] rota, int QtdPassageiros, int CapMax)
        {
            string hora = BuscaRota(inicio, fim, rota);

            if (hora != null && CapMax - QtdPassageiros >= vagas)
            {
                string resp = "" + (hora) + " " + "Onibus: " + Id;
                return resp;
            }
            return null;
        }
    }
}
