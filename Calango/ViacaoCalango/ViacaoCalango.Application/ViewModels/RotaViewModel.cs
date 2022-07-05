using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViacaoCalango.Application.ViewModels
{
    public class RotaViewModel : IEquatable<RotaViewModel>
    {
        public RotaViewModel(){}

        public string Nome { get; set; }

        public string Origem { get; set; }

        public string Destino { get; set; }

        public float Valor { get; set; }

        public RotaViewModel(string nome, string origem, string destino, float valor)
        {
            Nome = nome;
            Origem = origem;
            Destino = destino;
            Valor = valor;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as RotaViewModel);
        }

        public bool Equals(RotaViewModel other)
        {
            return other is not null &&
                   Nome == other.Nome &&
                   Origem == other.Origem &&
                   Destino == other.Destino &&
                   Valor == other.Valor;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Nome, Origem, Destino, Valor);
        }

        public string toString()
        {
            return Nome + " " + Origem + " " + Destino + " " + Valor;
        }


    }
}
