using BazarLojaApi.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazarLojaApi.Domain.Entities
{
    public class Pedidos : InterPedidos
    {
        public int Id { get; set; }
        public int IdCliente { get; set; }
        public double ValorTotal { get; set; }
        public int IdEntrega { get; set; }

        public InterPedidos _interPedidos;

        //Criando Construtores 

       
        public Pedidos() { } // Construtor vazio para no caso de usar só as propriedades

        public Pedidos( InterPedidos interPedidos) { _interPedidos = interPedidos; } //Uso Mock

        //Implementação da interface (colocando o ':' no lado do nome da classe )

        public void Create()
        {
            _interPedidos.Create();
        }

        public void Update()
        {
            _interPedidos.Update();
        }

        public void GetById()
        {
            _interPedidos.GetById();
        }

        public void GetAll()
        {
            _interPedidos.GetAll();
        }

        public void Delete()
        {
            _interPedidos.Delete();
        }

        public double CalcularValorTotalPedido()
        {
            return _interPedidos.CalcularValorTotalPedido();
        }

        public double CalcularValorTotalFrete()
        {
            return _interPedidos.CalcularValorTotalFrete();
        }
    }
}
