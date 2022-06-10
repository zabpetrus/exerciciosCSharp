using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.LojaoBazar.Domain.Entities
{
    public class ItensCarrinho
    {

        private int ID { get; set; }

        private int ProdutoID { get; set; }

        private int CarrinhoID { get; set; }

        private int Quantidade { get; set; }

        private double Preco { get; set; }

        private string NomeProduto { get; set; }


        //Setters

        public void setID(int v)
        {
            ID = v;
        }

        public void setProdutoID(int v)
        {
            ProdutoID = v;
        }

        public void setCarrinhoID(int v)
        {
            CarrinhoID = v;
        }

        public void setQuantidade(int v)
        {
            Quantidade = v;
        }

        public void setNomeProduto(string v)
        {
            NomeProduto = v;
        }

        public void setPreco(double v)
        {
            Preco = v;
        }

        //Getters

        public int getId() { return ID; }

        public int getProdutoID() { return ProdutoID; }

        public int getQuantidade() { return Quantidade; }

        public double getPreco() { return Preco; }  

        public string getNomeProduto() { return NomeProduto; }  

        public int getCarrinhoID() { return CarrinhoID; }   



        // Métodos Específicos

        public void Create() { }

        public double Update() { return 0.0; }

        public ItensCarrinho GetById() { return null; }

        public List<ItensCarrinho> GetAll() { return null;  }

        public double SimularFrete() { return 0.0; }

       
        public ItensCarrinho()  {  }
    }
}
