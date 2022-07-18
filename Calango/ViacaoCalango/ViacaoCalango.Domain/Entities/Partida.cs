using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViacaoCalango.Domain.Entities
{
    public class Partida
    {
        public int Id { get; set; }

        public string Onibus { get; set; }

        public string Rota { get; set; }    

        public string Trecho { get; set; }

        public string DataPartida { get; set; }

        public string HoraPartida { get; set; }

        public Partida(int id, string onibus, string rota, string trecho, string dataPartida, string horaPartida)
        {
            Id = id;
            Onibus = onibus;
            Rota = rota;
            Trecho = trecho;
            DataPartida = dataPartida;
            HoraPartida = horaPartida;
        }

        public Partida() { }

        public override bool Equals(object obj)
        {
            return obj is Partida partida &&
                   Id == partida.Id &&
                   Onibus == partida.Onibus &&
                   Rota == partida.Rota &&
                   Trecho == partida.Trecho &&
                   DataPartida == partida.DataPartida &&
                   HoraPartida == partida.HoraPartida;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Onibus, Rota, Trecho, DataPartida, HoraPartida);
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
