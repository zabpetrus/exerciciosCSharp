using Api.LojaoBazar.Domain.Entities;
using Api.LojaoBazar.Domain.Interfaces;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Api.LojaoBazar.Tests.Responses
{
    public class FecharPedido
    {
        [Fact]
        public void Test1()
        {
            Mock<IPedidosService> mockPedido = new Mock<IPedidosService>();
            mockPedido.Setup(m => m.CalcularValorTotalPedido()).Returns(1.36);

            Pedidos pedido = new Pedidos(mockPedido.Object);
            var res = pedido.CalcularValorTotalPedido();

            Assert.Equal(1.36, res);

        }
    }
}
