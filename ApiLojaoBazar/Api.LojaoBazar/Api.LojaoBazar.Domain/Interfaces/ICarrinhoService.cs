using Api.LojaoBazar.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.LojaoBazar.Domain.Interfaces
{
    public interface ICarrinhoService
    {
        public List<ItensCarrinho> GetItensCarrinho(int idCarrinho);
    }
}
