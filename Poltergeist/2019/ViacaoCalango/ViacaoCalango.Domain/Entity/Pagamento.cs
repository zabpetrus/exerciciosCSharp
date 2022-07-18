using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViacaoCalango.Domain.Entity
{
    public class Pagamento
    {
        public int IdPassageiro { get; set; }
        public double Valor { get; set; }
        public DateTime Data { get; set; }
    }
}
