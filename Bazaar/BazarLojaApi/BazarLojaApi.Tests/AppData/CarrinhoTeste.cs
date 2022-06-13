using BazarLojaApi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace BazarLojaApi.Tests.Outros
{
    public class CarrinhoTeste
    {
        [Fact]
        public void CreteCarrinho()
        {
            //Criando a instância do Carrinho para depois criá-la no Domain


            Carrinho carrinho = new Carrinho();
            carrinho.Id = 1;
            carrinho.dataCompra = DateTime.Now;
            carrinho.valorTotal = 2.5d;   // d = double  f = float  
            carrinho.frete = 23.9d;


            //Gerar um produto que será agora será carregado em ItensCarrinho
            Produtos produto = new Produtos();
            produto.Id = 123; 
            produto.Nome = "Camisa Surubinha do Kopp";
            produto.Quantidade = 5;
            produto.Preco = 2.3d;
            produto.Fornecedor = "Calçola Amarela LTDA";


            //Itens Carrinho recebe a instância de Carrinho
            ItensCarrinho itensCarrinho = new ItensCarrinho();
            itensCarrinho.Id = 1;
            itensCarrinho.IdCarrinho = 1; //O valor declarado acima: cada item terá o id do carrinho
            itensCarrinho.IdProduto = 123;
            itensCarrinho.Quantidade = 3;
            itensCarrinho.Preco = 2.6d;
            itensCarrinho.NomeProduto = "Camisa Surubinha do Kopp";


            Assert.NotNull(carrinho);


        }



    }
}
