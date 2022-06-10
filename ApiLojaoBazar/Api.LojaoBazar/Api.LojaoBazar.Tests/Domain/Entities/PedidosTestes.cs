using Api.LojaoBazar.Domain.Entities;
using Api.LojaoBazar.Domain.Interfaces;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Api.LojaoBazar.Tests.Domain.Entities
{
    public class PedidosTestes
    {
        [Fact]
        public void Teste1()
        {
            //Teste das Propriedades da Classe Pedido
            Pedidos pedidos = new Pedidos();
            pedidos.setId(1);
            pedidos.setIdCliente(1);
            pedidos.setIdEntrega(1);
            pedidos.setValorTotal(2.5d);
           
            Assert.NotNull(pedidos);

        }

        [Fact]
        public void Teste2()
        {
            //Teste dos Métodos da Classe Pedido
            Mock<IPedidosService> mock = new Mock<IPedidosService>();
            mock.Setup(m => m.CalcularValorTotalFrete()).Returns(2.3d);

            Pedidos pedidos = new Pedidos(mock.Object);
            var res = pedidos.CalcularValorTotalFrete();

            Assert.Equal(2.3d, res);


        }
    }
}
