using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.LojaoBazar.Domain.Interfaces
{
    public interface IPagamentoService
    {
        public bool CartaoValido();

        public bool GetPagamento(int id);   


    }
}
