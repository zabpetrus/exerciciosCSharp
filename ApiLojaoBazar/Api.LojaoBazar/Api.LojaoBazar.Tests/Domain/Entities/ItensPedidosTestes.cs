using Api.LojaoBazar.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Api.LojaoBazar.Tests.Domain.Entities
{
    public class ItensPedidosTestes
    {

        [Fact]
        public void Test1()
        {
            ItensPedidos itensPedidos = new ItensPedidos();
            itensPedidos.setId(1);
            itensPedidos.setIdProduto(1);
            itensPedidos.setQuantidade(5);
            itensPedidos.setPreco(5.8d);

            Assert.NotNull(itensPedidos);
        }
    }
}
