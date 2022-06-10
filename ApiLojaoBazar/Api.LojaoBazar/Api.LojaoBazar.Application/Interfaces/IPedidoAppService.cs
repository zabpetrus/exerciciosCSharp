using Api.LojaoBazar.Application.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.LojaoBazar.Application.Interfaces
{
    public interface IPedidoAppService
    {
        public void Create(PedidoCreateViewModel pedidoCreateViewModel);

        public PedidoResultViewModel CreatePedido(PedidoCreateViewModel pedidoCreateViewModel);             
                
        public PedidoResultViewModel GetById(int id);

    }
}
