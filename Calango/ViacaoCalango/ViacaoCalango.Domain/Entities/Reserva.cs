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

        public Reserva(int id, int passageiroID, int rotaID, int trechoOrigem, int trechoDestino, bool ida, bool volta, string classe, DateTime dataIda, DateTime dataVolta, DateTime horaEmbarque, float valor)
        {
            Id = id;
            PassageiroID = passageiroID;
            RotaID = rotaID;
            TrechoOrigem = trechoOrigem;
            TrechoDestino = trechoDestino;
            Ida = ida;
            Volta = volta;
            Classe = classe;
            DataIda = dataIda;
            DataVolta = dataVolta;
            HoraEmbarque = horaEmbarque;
            Valor = valor;
        }

        public Reserva()
        {
        }

        public override bool Equals(object obj)
        {
            return obj is Reserva reserva &&
                   Id == reserva.Id &&
                   PassageiroID == reserva.PassageiroID &&
                   RotaID == reserva.RotaID &&
                   TrechoOrigem == reserva.TrechoOrigem &&
                   TrechoDestino == reserva.TrechoDestino &&
                   Ida == reserva.Ida &&
                   Volta == reserva.Volta &&
                   Classe == reserva.Classe &&
                   DataIda == reserva.DataIda &&
                   DataVolta == reserva.DataVolta &&
                   HoraEmbarque == reserva.HoraEmbarque &&
                   Valor == reserva.Valor;
        }

        public override int GetHashCode()
        {
            HashCode hash = new HashCode();
            hash.Add(Id);
            hash.Add(PassageiroID);
            hash.Add(RotaID);
            hash.Add(TrechoOrigem);
            hash.Add(TrechoDestino);
            hash.Add(Ida);
            hash.Add(Volta);
            hash.Add(Classe);
            hash.Add(DataIda);
            hash.Add(DataVolta);
            hash.Add(HoraEmbarque);
            hash.Add(Valor);
            return hash.ToHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
