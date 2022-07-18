using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViacaoCalango.Domain.Entity
{
    public class Busao
    {
        public int IdBus { get; set; }
        public string TipoBus { get; set; }
        public int MaxPassageiros { get; set; }
        public string[,] Rota { get; set; }

        public Busao(int idbus, string tipobus, int Maxpass, string[,] rota)
        {
            IdBus = idbus;
            TipoBus = tipobus;
            MaxPassageiros = Maxpass;
            Rota = rota;
        }

        public string ReservaBus(string partida, string destido, int vagas, string[,] rota, int MaxPassageiros)
        {
            int inic = 0;
            int fim = 0;
            string Disp;
            string hora;

            foreach (var saida in rota)
            {
                if (saida == partida)
                {
                    foreach (var chegada in rota)
                    {
                        if (chegada == destido)
                        {
                            inic++;

                            string sai = rota[inic, 1];

                            fim++;

                            hora = "Partida: " + sai + " Chegada: " + rota[fim, 1];

                            if ((MaxPassageiros - Int32.Parse(rota[inic, 2])) < vagas)
                            {
                                Disp = (hora) + " Onibus: " + IdBus;
                            }
                            else
                            {
                                Disp = (hora) + "nenhuma vaga disponivel";
                            }

                            return Disp;
                        }
                    }
                }
            }
            return "Rota não encontrada";
        }
    }
}
