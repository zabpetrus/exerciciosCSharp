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
    public class SimulaFrete
    {
        [Fact]
        public void Test1()
        {
          
           

            Mock<ICorreioService> mock = new Mock<ICorreioService>();
            mock.Setup(m => m.CalculaFrete()).Returns(2.65);

            Frete frete = new Frete(mock.Object);
            frete.setAltura(5);
            frete.setAvisoRecebimento(false);
            frete.setCepDestino("13418560");
            frete.setCepOrigem("13484339");
            frete.setCodigoFormato(1);
            frete.setCodigoServico("40010");
            frete.setComprimento(30);
            frete.setDiametro(0);
            frete.setMaoPropria(false);
            frete.setPeso("1");
            frete.setValorDeclarado(0);

            var result = frete.CalculaFrete();

            Assert.Equal(2.65, result);



        }
    }
}
