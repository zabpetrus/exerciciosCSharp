using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.LojaoBazar.Domain.Entities
{
    public class ItensPedidos
    {
        private int Id { get; set; }

        private int IdProduto { get; set; }

        private int Quantidade { get; set; }

        private double Preco { get; set; }


        public void setId(int v)
        {
            Id = v;
        }

        public void setIdProduto(int v)
        {
            IdProduto = v;   
        }

        public void setQuantidade(int v)
        {
            Quantidade = v;
        }

        public void setPreco(double v)
        {
            Preco = v;
        }


        //Getters

        public int getId() { return Id; }

        public int getIdProduto() { return IdProduto; } 

        public int getQuantidade() { return Quantidade; }   

        public double getPreco() { return Preco; }  


    }
}
