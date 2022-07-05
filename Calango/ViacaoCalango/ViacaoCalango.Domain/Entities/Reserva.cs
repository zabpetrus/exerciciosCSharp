using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViacaoCalango.Domain.Entities
{
    public class Reserva
    {
        public int Id { get; set; }

        public int PassageiroID { get; set; } //Identificador do Passageiro

        public int RotaID { get; set; } //Identificacao da Rota

        public int TrechoOrigem { get; set; } //Identificacao do Trecho de Origem

        public int TrechoDestino { get; set; } //Identificacao do Trecho de Destino

        public bool Ida { get; set; } //Ida ou Volta -> se ida = 1, ida e volta = 2 passagens

        public bool Volta { get; set; } //Ida ou Volta -> se ida = 1, ida e volta = 2 passagens

        public string Classe { get; set; } //Economica, Leito ou Semileito

        public DateTime DataIda { get; set; } //Data da ida

        public DateTime DataVolta { get; set; } //Data da volta que pode ser nulo

        public DateTime HoraEmbarque { get; set; }

        public float Valor { get; set; } //Custo total


    }
}
