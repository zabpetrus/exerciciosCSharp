using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.LojaoBazar.Application.ViewModel
{
    public class PedidoCreateViewModel
    {

        private int IdCliente { get; set; }

        private double ValorTotal { get; set; }

        private int IdEntrega { get; set; }


        //Setters

        public void setIDCliente( int idCliente) { IdCliente = idCliente; }

        public void setValorTotal( double valorTotal ) { ValorTotal = valorTotal; }

        public void setIDEntrega( int idEntrega ) { IdEntrega = idEntrega; }

        //Getters

        public int getIdEntrega() { return IdEntrega; }

        public double getValorTotal() { return ValorTotal; }

        public int getIDCliente() { return IdCliente; } 


    }
}
