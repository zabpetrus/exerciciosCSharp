using Api.LojaoBazar.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Api.LojaoBazar.Tests.Domain.Entities
{
    public class CarrinhoTests
    {
        [Fact]
        public void Test1()
        {
            Carrinho carrinho = new Carrinho();
            carrinho.setID(1);
            carrinho.setDataCompra(new DateTime(2015, 12, 25));
            carrinho.setValorTotal(2.5d);
            carrinho.setFrete(5.6d);

            Assert.NotNull(carrinho);

        }
    }
}
