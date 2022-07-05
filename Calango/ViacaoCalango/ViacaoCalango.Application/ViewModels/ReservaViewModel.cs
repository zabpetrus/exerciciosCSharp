using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViacaoCalango.Application.ViewModels
{
    public class ReservaViewModel : IEquatable<ReservaViewModel>
    {
        public ReservaViewModel(){ }

        public int RotaID { get; set; } //Identificacao da Rota

        public int TrechoOrigem { get; set; } //Identificacao do Trecho de Origem

        public int TrechoDestino { get; set; } //Identificacao do Trecho de Destino

        public bool Ida { get; set; } //Ida ou Volta -> se ida = 1

        public bool Volta { get; set; } //Ida ou Volta -> se ida = 1

        public string Classe { get; set; } //Economica, Leito ou Semileito

        public DateTime DataIda { get; set; } //Data da ida

        public DateTime? DataVolta { get; set; } //Data da volta que pode ser nulo

        public DateTime HoraEmbarque { get; set; }

        public float Valor { get; set; } //Custo total

        public override bool Equals(object obj)
        {
            return Equals(obj as ReservaViewModel);
        }

        public bool Equals(ReservaViewModel other)
        {
            return other is not null &&
                   RotaID == other.RotaID &&
                   TrechoOrigem == other.TrechoOrigem &&
                   TrechoDestino == other.TrechoDestino &&
                   Ida == other.Ida &&
                   Volta == other.Volta &&
                   Classe == other.Classe &&
                   DataIda == other.DataIda &&
                   DataVolta == other.DataVolta &&
                   HoraEmbarque == other.HoraEmbarque &&
                   Valor == other.Valor;
        }

        public override int GetHashCode()
        {
            HashCode hash = new HashCode();
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

        public string toString(){

            return this.RotaID.ToString() +
            this.TrechoOrigem.ToString() +
            this.TrechoDestino.ToString() +
            this.Ida +
            this.Volta +
            this.Classe.ToString() +
            this.DataIda.ToString() +
            this.DataVolta.ToString() +
            this.HoraEmbarque.ToString() +
            this.Valor.ToString();
        }

        public ReservaViewModel(int rotaID, int trechoOrigem, int trechoDestino, bool ida, bool volta, string classe, DateTime dataIda, DateTime dataVolta, DateTime horaEmbarque, float valor)
        {
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
    }
}
