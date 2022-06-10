using Api.LojaoBazar.Domain.Entities;
using Api.LojaoBazar.Domain.Interfaces;
using Api.LojaoBazar.Domain.Services;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Api.LojaoBazar.Tests.Domain.Services
{
    public class ItensCarrinhoServiceTests
    {
        [Fact]
        public void teste1()
        {
            ItensCarrinho item1 = new ItensCarrinho();
            item1.setID(1);
            item1.setNomeProduto("Teste");
            item1.setPreco(2.3d);
            item1.setCarrinhoID(2);
            item1.setProdutoID(2);
            item1.setQuantidade(2);

            ItensCarrinho item2 = new ItensCarrinho();
            item2.setID(2);
            item2.setNomeProduto("Teste2");
            item2.setPreco(23.7d);
            item2.setCarrinhoID(2);
            item2.setProdutoID(23);
            item2.setQuantidade(2);


            List<ItensCarrinho> lista = new List<ItensCarrinho>();
            lista.Add(item1);
            lista.Add(item2);


            Mock<ICarrinhoService> mock = new Mock<ICarrinhoService>();
            mock.Setup(m => m.GetItensCarrinho(2)).Returns(lista);

            ItensCarrinhoService itensCarrinhoService = new ItensCarrinhoService(mock.Object);
            var temp = itensCarrinhoService.GetItensCarrinho(2);

            Assert.Equal(lista, temp);

        }
    }
}
