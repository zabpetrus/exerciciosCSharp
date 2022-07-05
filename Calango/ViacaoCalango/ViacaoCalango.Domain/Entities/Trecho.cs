using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViacaoCalango.Domain.Entities
{
    public class Trecho
    {
        public int TrechoId { get; set; }   

        public string TrechoName { get; set; }

        public int RotaID { get; set; }

        public int RotaPosicao { get; set; }


    }
}
