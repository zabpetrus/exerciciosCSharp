using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.LojaoBazar.Domain.Entities
{
    public class Carrinho
    {
        private int Id { get; set; }
        private DateTime DataCompra { get; set; }
        private double ValorTotal { get; set; }
        private double Frete { get; set; }

        //Setters

        public void setID(int v)
        {
            Id = v;
        }

        public void setDataCompra(DateTime dateTime)
        {
            DataCompra = dateTime;
        }

        public void setValorTotal(double v)
        {
            ValorTotal = v;
        }

        public void setFrete(double v)
        {
            Frete = v;
        }

        //Getters

        public int getID() { return Id; }

        public DateTime getDataCompra() { return DataCompra; }

        public double getValorTotal() { return ValorTotal; }

        public double getFrete() { return Frete; }


    }
}
