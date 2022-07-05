using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViacaoCalango.Application.ViewModels
{
    public class PassageiroViewModel : IEquatable<PassageiroViewModel>
    {
     
        public String Nome { get; set; }

        public String CPF { get; set; }

        public String DataNascimento { get; set; }

        public PassageiroViewModel(){ }

        public PassageiroViewModel(string nome, string cPF, String dataNascimento)
        {
            Nome = nome;
            CPF = cPF;
            DataNascimento = dataNascimento;
        }

        public string toString()
        {
            return this.Nome + " : " + this.CPF + " : " + this.DataNascimento;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as PassageiroViewModel);
        }

        public bool Equals(PassageiroViewModel other)
        {
            return other is not null &&
                   Nome == other.Nome &&
                   CPF == other.CPF &&
                   DataNascimento == other.DataNascimento;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Nome, CPF, DataNascimento);
        }
    }
}
