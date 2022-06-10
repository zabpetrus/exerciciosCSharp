using Api.LojaoBazar.Domain.Entities;
using Api.LojaoBazar.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.LojaoBazar.Domain.Services
{
    public class ItensCarrinhoService
    {
        private ICarrinhoService _carrinhoService;

        public ItensCarrinhoService(ICarrinhoService carrinhoService)
        {
            _carrinhoService = carrinhoService;
        }

        public List<ItensCarrinho> GetItensCarrinho ( int idCarrinho )
        {
            return _carrinhoService.GetItensCarrinho(idCarrinho);
        }
    }
}
