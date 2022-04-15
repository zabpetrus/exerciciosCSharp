using System;
using System.Linq;
using WSCorreiosPreco;

/******************************************************************************************

Exemplo de como se conectar ao site dos Correios e usar a API de calculo da Taxa de Entrega
Atualização do exemplo encontrado no site 
http://www.andrealveslima.com.br/blog/index.php/2016/09/07/acessando-os-web-services-dos-correios-com-c-e-vb-net-consulta-de-ceps-e-precos/

Para calcular o valor de frete dos produtos, necessitamos de utilizar a api dos correios:
disponivel em: http://ws.correios.com.br/calculador/CalcPrecoPrazo.asmx

Importamos essa api no Visual Studio 2019 da seguinte forma:
1 - Vamos ao Gerenciador de Soluções (onde mostra a estrutura do projeto) e clicamos c/ botão direito do mouse em cima da pasta do projeto
2 - Adicionar -> Referência de Serviço -> WCF WebService e clique Próximo;
3 - No campo uri, coloque o endereco da api dos correios, ou seja, http://ws.correios.com.br/calculador/CalcPrecoPrazo.asmx
4 - Clique no botão ir. Vai aparecer um valor ( ou a mensagem "Aviso: Um ou mais erros.", mas se for assim, ignore o erro:
    Provavelmente, alguns dos modulos estarão já carregados. É só clicar em cima para visualizar );
5 - Com o serviço já listado, renomeie o Namespace para "WSCorreiosPreco", clique em Próximo, Próximo e Concluir;
6 - Para utilizarmos o serviço, importamos o mesmo com a diretriz "using <Nome do Serviço>", que no caso é WSCorreiosPreco;
7 - Utilizamos a classe parcial CalcPrecoPrazoWSSoapClient, que recebe um enum como argumento;
8 - Esse ennum é responsavel pela configuração de endpoint. Temos dois valores possíveis (até o momento: )

     CalcPrecoPrazoWSSoapClient.EndpointConfiguration.CalcPrecoPrazoWSSoap;
     CalcPrecoPrazoWSSoapClient.EndpointConfiguration.CalcPrecoPrazoWSSoap12;

No caso, o primeiro deu certo. Depois, é só chamarmos a função CalcPrecoPrazo a partir dessa classe e inserir os argumentos necessários.


*******************************************************************************************/
namespace ConsoleConnectiongAPI
{
    

    class Program
    {
        static void Main(string[] args)
        {

            System.Console.Write("Digite o código do tipo de envio: ");
            var tipoEnvio = System.Console.ReadLine();
            System.Console.Write("Digite o CEP de origem: ");
            var cepOrigem = System.Console.ReadLine();
            System.Console.Write("Digite o CEP de destino: ");
            var cepDestino = System.Console.ReadLine();
            System.Console.Write("Digite o peso (kg): ");
            var peso = System.Console.ReadLine();
            System.Console.Write("Digite o código do formato (caixa, envelope, etc): ");
            var codigoFormato = System.Console.ReadLine();
            System.Console.Write("Digite o comprimento: ");
            var comprimento = System.Console.ReadLine();
            System.Console.Write("Digite a altura: ");
            var altura = System.Console.ReadLine();
            System.Console.Write("Digite a largura: ");
            var largura = System.Console.ReadLine();
            System.Console.Write("Digite o diâmetro: ");
            var diametro = System.Console.ReadLine();
            System.Console.Write("Entrega em mão própria (S/N)?: ");
            var maoPropria = System.Console.ReadLine();
            System.Console.Write("Digite o valor declarado: ");
            var valorDeclarado = System.Console.ReadLine();
            System.Console.Write("Aviso de recebimento (S/N)?: ");
            var avisoRecebimento = System.Console.ReadLine();

            try
            {
                int codigoFormatoInt;
                if (!int.TryParse(codigoFormato, out codigoFormatoInt))
                    throw new Exception("Código do formato inválido");
                decimal comprimentoDecimal;
                if (!decimal.TryParse(comprimento, out comprimentoDecimal))
                    throw new Exception("Comprimento inválido");
                decimal alturaDecimal;
                if (!decimal.TryParse(altura, out alturaDecimal))
                    throw new Exception("Altura inválida");
                decimal larguraDecimal;
                if (!decimal.TryParse(largura, out larguraDecimal))
                    throw new Exception("Largura inválida");
                decimal diametroDecimal;
                if (!decimal.TryParse(diametro, out diametroDecimal))
                    throw new Exception("Diâmetro inválido");
                decimal valorDeclaradoDecimal;
                if (!decimal.TryParse(valorDeclarado, out valorDeclaradoDecimal))
                    throw new Exception("Valor declarado inválido");

                //CalcPrecoPrazoWSSoapClient.EndpointConfiguration endpointConfiguration; //serviceEndpoint
                //CalcPrecoPrazoWSSoapClient.EndpointConfiguration.CalcPrecoPrazoWSSoap;
                //CalcPrecoPrazoWSSoapClient.EndpointConfiguration.CalcPrecoPrazoWSSoap12;


                var ws = new CalcPrecoPrazoWSSoapClient( CalcPrecoPrazoWSSoapClient.EndpointConfiguration.CalcPrecoPrazoWSSoap );
                var resposta = ws.CalcPrecoPrazo(string.Empty, string.Empty, tipoEnvio, cepOrigem, cepDestino, peso, codigoFormatoInt, comprimentoDecimal, alturaDecimal, larguraDecimal, diametroDecimal, maoPropria, valorDeclaradoDecimal, avisoRecebimento);

                var respostaReal = resposta.Servicos.FirstOrDefault();
             
                if (respostaReal != null)
                {
                    Console.WriteLine();
                    Console.WriteLine("Prazo: {0} dia", respostaReal.PrazoEntrega);
                    Console.WriteLine("Valor: R$ {0}", respostaReal.Valor);
                }
                else
                {
                    throw new Exception("Não foi possível encontrar os valores dentro da resposta do serviço");
                }

            }
            catch (Exception ex)
            {
                System.Console.WriteLine("Erro ao efetuar cálculos: {0}", ex.Message);
            }

            

        }
    }
}
