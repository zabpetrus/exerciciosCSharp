using Api.LojaoBazar.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.LojaoBazar.Domain.Entities
{
    public class Pagamento : IPagamentoService
    {

        private double Valor { get; set; }

        private int clienteID { get; set; }

        private char FormaPagamento { get; set; }

        private IPagamentoService _pagamentoService;

        //Construtores

        public Pagamento() { }

        public Pagamento(IPagamentoService pagamentoService)
        {          
            _pagamentoService = pagamentoService;
        }

        //Setters

        public void setValor(double v){ Valor = v; }

        public void setClienteID(int _clienteID){ clienteID = _clienteID; }

        public void setFormaPagamento(char v){ FormaPagamento = v;  }

        //Getters

        public int getClienteID(){ return clienteID; }

        public double getValor(){ return Valor; }

        public char getFormaPagamento() { return FormaPagamento; }


        //Métodos da Interface

        public bool CartaoValido()
        {
            return _pagamentoService.CartaoValido();
        }

        public bool GetPagamento(int id)
        {
            return _pagamentoService.GetPagamento(id);
        }
    }
}
