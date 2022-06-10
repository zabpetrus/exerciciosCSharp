using Api.LojaoBazar.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Api.LojaoBazar.Tests.Domain.Entities
{
    public class ItensCarrinhoTestes
    {
        [Fact]
        public void Test1()
        {

            ItensCarrinho itensCarrinho = new ItensCarrinho();
            itensCarrinho.setID(1);
            itensCarrinho.setCarrinhoID(1);
            itensCarrinho.setProdutoID(1);
            itensCarrinho.setQuantidade(5);
            itensCarrinho.setPreco(5.69d);
            itensCarrinho.setNomeProduto("Camisa branca");

            Assert.NotNull(itensCarrinho);

        }
    }
}
