using Moq;
using System;
using webapplicationapi;
using Xunit;

namespace webprojectapitestes
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Mock<ICorreioService> mock = new Mock<ICorreioService>();
            // mock.Setup(m => m.CalculaFrete(21857010, 5)).Returns(7.52);
            mock.Setup(m => m.CalculaFrete()).Returns(7.52);

            Frete frete = new Frete(mock.Object)
            {
                cep = 21857010,
                peso = 5
            };

            double resultado = frete.CalculaFrete();
            Assert.Equal(7.52, resultado);
        }
    }
}
