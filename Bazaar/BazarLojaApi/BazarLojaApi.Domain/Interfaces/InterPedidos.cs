using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazarLojaApi.Domain.Interfaces
{
    public interface InterPedidos
    {
        public void Create();

        public void Update();

        public void GetById();

        public void GetAll();

        public void Delete();

        public double CalcularValorTotalPedido();

        public double CalcularValorTotalFrete();

    }
}
