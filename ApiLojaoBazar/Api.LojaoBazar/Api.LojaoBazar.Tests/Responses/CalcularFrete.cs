using Api.LojaoBazar.Domain.Entities;
using Api.LojaoBazar.Domain.Interfaces;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Api.LojaoBazar.Tests.Responses
{
    public class CalcularFrete
    {
        [Fact]
        public void Test1()
        {
            //Mock Frete

            Mock<ICorreioService> fretemock = new Mock<ICorreioService>();
            fretemock.Setup(m => m.CalculaFrete()).Returns(2.69);

            Frete frete = new Frete(fretemock.Object);
            double resFrete = frete.CalculaFrete();

            Assert.Equal(2.69, resFrete);
        }
    }
}
