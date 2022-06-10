using Api.LojaoBazar.Application.Interfaces;
using Api.LojaoBazar.Application.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.LojaoBazar.Application.AppService
{
    public class PedidoAppService : IPedidoAppService
    {

        private IPedidoAppService _pedidoAppService;

        public PedidoAppService() { }

        public PedidoAppService(IPedidoAppService pedidoAppService)
        {
            _pedidoAppService = pedidoAppService;
        }

        public void Create(PedidoCreateViewModel pedidoCreateViewModel)
        {
           _pedidoAppService.Create(pedidoCreateViewModel);
            
        }

        public PedidoResultViewModel CreatePedido(PedidoCreateViewModel pedidoCreateViewModel)
        {
            return _pedidoAppService.CreatePedido(pedidoCreateViewModel);
        }

        public PedidoResultViewModel GetById(int id)
        {
            return _pedidoAppService.GetById(id);   
        }
    }
}
