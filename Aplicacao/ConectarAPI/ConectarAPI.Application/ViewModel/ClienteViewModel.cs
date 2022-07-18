using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConectarAPI.Application.ViewModel
{
    public class ClienteViewModel
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public DateTime DataNascimento { get; set; }

        public override bool Equals(object? obj)
        {
            return obj is ClienteViewModel model &&
                   Id == model.Id &&
                   Nome == model.Nome &&
                   DataNascimento == model.DataNascimento;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Nome, DataNascimento);
        }

        public override string? ToString() => $"{Id} {Nome} {DataNascimento} ";

    }
}
