using ConecttingAPI.Models;
using Moq;
using System;
using Xunit;

/*****************************************************************************
 *                           Classe de teste
 *            Depois de instalar o Moq no projeto de testes 
 *              importar as depend�ncias para o projeto: 
 *        Clicar no bot�o direito do mouse sobre o nome do projeto:
 *  Adicionar -> Refer�ncia de Projeto -> Clicar na op��o ConnectingAPI
 *                  E se o VS n�o importar diretamente
 *               adicione using Moq e using ConecttingAPI.Models
 *  Provavelmente estar�o listadas  pelo intellisense para corrigir o erro
 * **************************************************************************/

namespace ConnecttingAPITeste
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //Arrange
            Mock<ICorreioService> mock = new Mock<ICorreioService>();
            mock.Setup(m => m.CalculaFrete()).Returns(7.52);

            Frete frete = new Frete(mock.Object)
            {
                //Mudei o numero de argumentos
                //cep = 21857010,
                //peso = 5
            };

            double resultado = frete.CalculaFrete();
            Assert.Equal(7.52, resultado);
        }

        [Fact]
        public void Test2()
        {


        }
    }
}
