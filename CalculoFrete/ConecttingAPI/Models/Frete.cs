using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebServiceCorreios;

namespace ConecttingAPI.Models
{       

    public class Frete
    {

        private ICorreioService correioService; //Interface paa ser usada no teste
        //public int cep { get; set; } //Era assim
        //public double peso { get; set; } // Era assim

        //Parametros necessarios para calculo do frete
        public string nCdEmpresa { get; set; }
        public string sDsSenha { get; set; }
        public string tipoEnvio { get; set; }
        public string cepOrigem { get; set; }
        public string cepDestino { get; set; }
        public string peso { get; set; }
        public int codigoFormatoInt { get; set; }
        public decimal comprimentoDecimal { get; set; }
        public decimal alturaDecimal { get; set; }
        public decimal larguraDecimal { get; set; }
        public decimal diametroDecimal { get; set; }
        public string maoPropria { get; set; }
        public decimal valorDeclaradoDecimal { get; set; }
        public string avisoRecebimento { get; set; }


        public Frete(ICorreioService _correioService) { correioService = _correioService; } //Para o teste funcionar

        public Frete() { } //Sobrecarga do construtor - Posso chamar a classe utilizando new Frete() e chamar as propriedades depois

        public double CalculaFrete()
        {
            //Implementação da Camada de API dos Correios
           
            ConnectCorreiosService connectCorreioService = new ConnectCorreiosService(
                nCdEmpresa, 
                sDsSenha,
                tipoEnvio,
                cepOrigem,
                cepDestino,
                peso,
                codigoFormatoInt,
                comprimentoDecimal,
                alturaDecimal,
                larguraDecimal,
                diametroDecimal,
                maoPropria,
                valorDeclaradoDecimal,
                avisoRecebimento        
                );
            double frete = connectCorreioService.Calcular();

           //O método aqui (CalculaFrete) é igualado ao retorno do método CalculaFrete da Interface-> double = double 
           //return correioService.CalculaFrete();
            return frete; 
          
        }

    }
}
