using Api.LojaoBazar.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Api.LojaoBazar.Tests.Domain.Entities
{
    public class ProdutosTests
    {
        [Fact]
        public void Test1()
        {
            Produto produto = new Produto();
            produto.setId(1);
            produto.setNome("Casaco de Couro ");
            produto.setQuantidade(5);
            produto.setPreco(12.6d);
            produto.setFornecedor("Adidas do Brasil");

            Assert.NotNull(produto);
        }
    }
}
