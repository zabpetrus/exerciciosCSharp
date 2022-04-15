using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WSCorreiosPreco;

namespace WebServiceCorreios
{
    public class ConnectCorreiosService
    {
        private string resultado;

        public ConnectCorreiosService(

            string nCdEmpresa,
            string sDsSenha, 
            string tipoEnvio, 
            string cepOrigem, 
            string cepDestino, 
            string peso, 
            int codigoFormatoInt, 
            decimal comprimentoDecimal, 
            decimal alturaDecimal, 
            decimal larguraDecimal,
            decimal diametroDecimal, 
            string maoPropria, 
            decimal valorDeclaradoDecimal, 
            string avisoRecebimento
            )
        {
            try
            {
                var ws = new CalcPrecoPrazoWSSoapClient(CalcPrecoPrazoWSSoapClient.EndpointConfiguration.CalcPrecoPrazoWSSoap);
                var resposta = ws.CalcPrecoPrazo(nCdEmpresa, sDsSenha, tipoEnvio, cepOrigem, cepDestino, peso, codigoFormatoInt, comprimentoDecimal, alturaDecimal, larguraDecimal, diametroDecimal, maoPropria, valorDeclaradoDecimal, avisoRecebimento);
                this.resultado = resposta.Servicos.FirstOrDefault().Valor;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
           
        }

        public double Calcular()
        {
            return Convert.ToDouble(this.resultado);           
       
        }
    }
}
