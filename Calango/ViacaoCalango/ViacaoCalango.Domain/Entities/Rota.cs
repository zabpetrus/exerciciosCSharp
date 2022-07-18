using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViacaoCalango.Domain.Entities
{
    public class Rota
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Origem { get; set; }  

        public string Destino { get; set; }

        public float Valor { get; set; }

        public Rota(int id, string nome, string origem, string destino, float valor)
        {
            Id = id;
            Nome = nome;
            Origem = origem;
            Destino = destino;
            Valor = valor;
        }

        public Rota()
        {
        }

        public override bool Equals(object obj)
        {
            return obj is Rota rota &&
                   Id == rota.Id &&
                   Nome == rota.Nome &&
                   Origem == rota.Origem &&
                   Destino == rota.Destino &&
                   Valor == rota.Valor;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Nome, Origem, Destino, Valor);
        }

        public override string ToString()
        {
            return this.Id + this.Nome + this.Origem + this.Destino;    
        }
    }
}
