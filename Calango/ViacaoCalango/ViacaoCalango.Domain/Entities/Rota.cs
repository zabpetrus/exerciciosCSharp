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

    }
}
