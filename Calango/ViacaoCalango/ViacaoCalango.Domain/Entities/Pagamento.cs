using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViacaoCalango.Domain.Entities
{
    public class Pagamento
    {
        public int PassageiroID { get; set; }

        public bool Status { get; set; } //Pago ou não

    }
}
