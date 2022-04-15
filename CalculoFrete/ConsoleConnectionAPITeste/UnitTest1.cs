using System;
using Xunit;
using System.Linq;
using WSCorreiosPreco;
using Moq;

namespace ConsoleConnectionAPITeste
{
    //Teste feito em 15/04/2022 - Pode muita coisa mudar até então
    //Teste feito sem mockup - para verificar se o serviço foi importado corretamente

    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            string nCdEmpresa = string.Empty;
            string sDsSenha = string.Empty;
            string tipoEnvio = "40010";
            string cepOrigem = "13484339";
            string cepDestino = "13418560";
            string peso = "1";
            int codigoFormatoInt = 1;
            decimal comprimentoDecimal = 30;
            decimal alturaDecimal = 5;
            decimal larguraDecimal = 20;
            decimal diametroDecimal = 0;
            string maoPropria = "N";
            decimal valorDeclaradoDecimal = 0;
            string avisoRecebimento = "N";

            try
            {
                var ws = new CalcPrecoPrazoWSSoapClient(CalcPrecoPrazoWSSoapClient.EndpointConfiguration.CalcPrecoPrazoWSSoap);
                var resposta = ws.CalcPrecoPrazo( nCdEmpresa, sDsSenha, tipoEnvio, cepOrigem, cepDestino, peso, codigoFormatoInt, comprimentoDecimal, alturaDecimal, larguraDecimal, diametroDecimal, maoPropria, valorDeclaradoDecimal, avisoRecebimento);

                var respostaReal = resposta.Servicos.FirstOrDefault();

                if (respostaReal != null)
                {
                    Console.WriteLine();
                    Console.WriteLine("Prazo: {0} dia", respostaReal.PrazoEntrega);
                    Console.WriteLine("Valor: R$ {0}", respostaReal.Valor);

                    string valor = resposta.Servicos.FirstOrDefault().ToString().Trim();

                    Assert.Equal("22,50", valor);
                }
                else
                {
                    throw new Exception("Não foi possível encontrar os valores dentro da resposta do serviço");
                }
            }
            catch(Exception e)
            {
                System.Console.WriteLine("Erro ao efetuar cálculos: {0}", e.Message);
            }          

        }

        [Fact]
        public void Test2()
        {
            //Inicializando o mock para o Visual Studio importar o pacote recém instalado
            //Mock<String> mock = new Mock<string>();

            //Depois mudarei o casting para a classe correta
            //Mock<CalcPrecoPrazoWSSoapClient> mock = new Mock<CalcPrecoPrazoWSSoapClient>();
            //Ainda não testado

        }



    }
}
