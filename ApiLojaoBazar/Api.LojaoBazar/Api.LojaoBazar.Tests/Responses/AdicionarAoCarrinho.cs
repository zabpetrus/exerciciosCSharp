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
    public class AdicionarAoCarrinho
    {
        [Fact]
        public void Test1()
        {
            //Inicialização do Objeto Carrinho

            Carrinho carrinho = new Carrinho();
            carrinho.setID(5);
            carrinho.setDataCompra(DateTime.Now);
          

            Produto produto1 = new Produto();
            produto1.setNome("Notebook Acer Aspire 3 Intel Core");
            produto1.setQuantidade(1);
            produto1.setId(4);
            produto1.setFornecedor("Acer");
            produto1.setPreco(3024.20);


            Produto produto2 = new Produto();
            produto2.setNome("Chocolate kit kat dark 41,5G");
            produto2.setQuantidade(7);
            produto2.setId(4);
            produto2.setFornecedor("Nestle");
            produto2.setPreco(3.69);

            //Mock Frete

            Mock<ICorreioService> fretemock = new Mock<ICorreioService>();
            fretemock.Setup(m => m.CalculaFrete()).Returns(2.69);

            Frete frete = new Frete(fretemock.Object);
            double resFrete = frete.CalculaFrete();

            Assert.Equal(2.69, resFrete);


            ItensCarrinho item1 = new ItensCarrinho();
            item1.setID(1); //gerado automaticamente 
            item1.setNomeProduto( produto1.getNome() );
            item1.setPreco( produto1.getPreco() );
            item1.setProdutoID( produto1.getId() );
            item1.setCarrinhoID(5); //ID do objeto carrinho

            ItensCarrinho item2 = new ItensCarrinho();
            item2.setID(2);//gerado automaticamente 
            item2.setNomeProduto( produto2.getNome() );
            item2.setPreco( produto2.getPreco() );
            item2.setProdutoID( produto2.getId() );
            item2.setCarrinhoID(5); //ID do objeto carrinho

            carrinho.setFrete(resFrete);
            carrinho.setValorTotal(3052.72);

            Assert.Equal(carrinho.getFrete(), resFrete);
        }
    }
}
