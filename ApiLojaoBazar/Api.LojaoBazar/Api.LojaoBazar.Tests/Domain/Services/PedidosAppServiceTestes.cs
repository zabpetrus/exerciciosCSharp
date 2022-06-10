using Api.LojaoBazar.Application.AppService;
using Api.LojaoBazar.Application.Interfaces;
using Api.LojaoBazar.Application.ViewModel;
using Api.LojaoBazar.Domain.Entities;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Api.LojaoBazar.Tests.Domain.Services
{
    public class PedidosAppServiceTestes
    {
        [Fact]
        public void PedidoResultTest1()
        {     

            PedidoResultViewModel pedidoResultViewModel = new PedidoResultViewModel();
            pedidoResultViewModel.setIDCliente(1);
            pedidoResultViewModel.setIDEntrega(2);
            pedidoResultViewModel.setValorTotal(2.5d);
            pedidoResultViewModel.setID(1);


            PedidoCreateViewModel pedidoCreateViewModel = new PedidoCreateViewModel();
            pedidoCreateViewModel.setIDCliente(1);
            pedidoCreateViewModel.setIDEntrega(2);
            pedidoCreateViewModel.setValorTotal(2.5d);


            Mock<IPedidoAppService> mockAppService = new Mock<IPedidoAppService>();
            mockAppService.Setup(m => m.CreatePedido(pedidoCreateViewModel)).Returns(pedidoResultViewModel);    

            PedidoAppService pedidoAppService = new PedidoAppService(mockAppService.Object);
            var result = pedidoAppService.CreatePedido(pedidoCreateViewModel);

            Assert.NotNull(result);
            Assert.Equal(pedidoResultViewModel, result);
           
        }

        [Fact]
        public void PedidoResultTest2()
        {
            Cliente cliente = new Cliente();
            cliente.setId(1);
            cliente.setNome("Manuel");
            cliente.setCpf("654.369.554-56");
            cliente.setSenha("123456");
            cliente.setEmail("manuel@gmail.com");

            Entrega entrega = new Entrega();
            entrega.setId(1);
            entrega.setStatus(true);

            Pedidos pedido = new Pedidos();
            pedido.setId(1);
            pedido.setIdEntrega(1);
            pedido.setIdCliente(1);
            pedido.setValorTotal( 2.6d ); 


            PedidoResultViewModel pedidoResultViewModel = new PedidoResultViewModel();
            pedidoResultViewModel.setIDCliente( cliente.getID() );
            pedidoResultViewModel.setIDEntrega( entrega.getId() );
            pedidoResultViewModel.setValorTotal( pedido.getValorTotal());
            pedidoResultViewModel.setID(1);


            PedidoCreateViewModel pedidoCreateViewModel = new PedidoCreateViewModel();
            pedidoCreateViewModel.setIDCliente( cliente.getID());
            pedidoCreateViewModel.setIDEntrega( entrega.getId() );
            pedidoCreateViewModel.setValorTotal( pedido.getValorTotal() );


            Mock<IPedidoAppService> mockAppService = new Mock<IPedidoAppService>();
            mockAppService.Setup(m => m.CreatePedido(pedidoCreateViewModel)).Returns(pedidoResultViewModel);

            PedidoAppService pedidoAppService = new PedidoAppService(mockAppService.Object);
            var result = pedidoAppService.CreatePedido(pedidoCreateViewModel);

            Assert.NotNull(result);
            Assert.Equal(pedidoResultViewModel, result);
        }


    }
}
