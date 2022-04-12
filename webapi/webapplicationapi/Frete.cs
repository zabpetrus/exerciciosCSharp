using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webapplicationapi
{
    public class Frete
    {
        public int cep { get; set; }
        private ICorreioService correioService;
        public double peso { get; set; }
        public double dimensoes { get; set; }


        
        public Frete(ICorreioService _correioService)
        {
            correioService = _correioService;
        }

        //Esta função deve ser devidamente implementada
        public double CalculaFrete()
        {
            //Retorno apenas com função de testes
            //return correioService.CalculaFrete();

            //Ainda vai ser implementado
            double ncep = Convert.ToDouble(this.cep);
            return ncep * this.peso;

            
        }
    }
}
