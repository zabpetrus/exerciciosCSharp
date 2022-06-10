using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.LojaoBazar.Domain.Interfaces
{
    public interface IPedidosService
    {
        public void Update();
       
        public void GetById();
     
        public void Create();
       
        public void Delete();
      
        public double CalcularValorTotalPedido();       

        public double CalcularValorTotalFrete();

        public void GetAll();        

    }
}
