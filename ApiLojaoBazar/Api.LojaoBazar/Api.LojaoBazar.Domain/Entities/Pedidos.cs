using Api.LojaoBazar.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.LojaoBazar.Domain.Entities
{
    public class Pedidos : IPedidosService
    {
        private int Id { get; set; }

        private int IdCliente { get; set; } 

        private double ValorTotal { get;set; }

        private int IdEntrega { get; set; }


        private IPedidosService _pedidosService;

       
        //Setters
        public void setId(int id ) { this.Id = id; }    

        public void setIdCliente( int idCliente) { this.IdCliente = idCliente;  }
        
        public void setValorTotal( double valorTotal ) { this.ValorTotal = valorTotal; }       

        public void setIdEntrega( int idEntrega ) { this.IdEntrega = idEntrega; }


        //Getters
        public int getId() { return this.Id; }  

        public int getIdCliente() { return this.IdCliente; }

        public double getValorTotal() { return this.ValorTotal; }

        public int getIdEntrega() { return this.IdEntrega; }


        //Construtores
        public Pedidos() { }


        public Pedidos(IPedidosService pedidosService)
        {
            _pedidosService = pedidosService;
        }

        //Métodos Exclusivos

        public void Update()
        {
            _pedidosService.Update();
        }

        public void GetById()
        {
            _pedidosService.GetById();
        }

        public void Create()
        {
            _pedidosService.Create();
        }

        public void Delete()
        {
            _pedidosService.Delete();
        }

        public double CalcularValorTotalPedido()
        {
            return _pedidosService.CalcularValorTotalPedido();
        }

        public double CalcularValorTotalFrete()
        {
            return _pedidosService.CalcularValorTotalFrete();
            
        }

        public void GetAll()
        {
             _pedidosService.GetAll();
        }


    }
}
