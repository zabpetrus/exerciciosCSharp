using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazarLojaApi.Domain.Entities
{
    public class Carrinho
    {
        public int Id { get; set; }

        public DateTime dataCompra { get; set; }

        public double valorTotal { get; set; }
       
        public double frete { get; set; }
        
    }
}
