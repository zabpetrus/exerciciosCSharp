using BazarLojaApi.Domain.Entities;
using BazarLojaApi.Domain.Interfaces;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace BazarLojaApi.Tests.AppData
{
    public class PedidosTestes
    {
        [Fact]
        public void Test1()
        {
            Pedidos pedidos = new Pedidos();
            pedidos.Id = 1;
            pedidos.IdCliente = 1;
            pedidos.ValorTotal = 2.5d;
            pedidos.IdEntrega = 2;

            Assert.NotNull(pedidos);
        }

        [Fact]
        public void Test2()
        {
            Mock<InterPedidos> mock = new Mock<InterPedidos>();
            mock.Setup(m => m.CalcularValorTotalFrete()).Returns(2.5d);

            Pedidos pedidos = new Pedidos(mock.Object);
            var res = pedidos.CalcularValorTotalFrete();

            Assert.Equal(2.5d, res);
        }
    }
}
