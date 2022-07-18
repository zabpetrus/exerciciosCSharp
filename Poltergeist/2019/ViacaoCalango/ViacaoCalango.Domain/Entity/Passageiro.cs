using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViacaoCalango.Domain.Entity
{
    public class Passageiro
    {
        public int Id { get; set; }
        public string LocalInicio { get; set; }
        public string LocalFim { get; set; }
        public string TipoPoltrona { get; set; }
    }
}
