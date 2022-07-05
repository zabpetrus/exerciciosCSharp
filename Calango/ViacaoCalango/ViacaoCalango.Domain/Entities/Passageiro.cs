using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViacaoCalango.Domain.Entities
{
    public class Passageiro
    {
        public int Id { get; set; }

        public String Nome { get; set; }

        public String CPF { get; set; }

        public String DataNascimento { get; set; }



        public Passageiro(int id, string nome, string cPF, String dataNascimento)
        {
            Id = id;
            Nome = nome;
            CPF = cPF;
            DataNascimento = dataNascimento;
        }

        public Passageiro()
        {
        }
    }
}
