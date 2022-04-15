using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConecttingAPI.Models
{
    public interface ICorreioService
    {

        public double CalculaFrete();

        public double CalculaFrete(int cep, double peso);

    }
}
