using Api.LojaoBazar.Domain.Entities;
using Api.LojaoBazar.Domain.Interfaces;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Api.LojaoBazar.Tests.Domain.Entities
{
    public class FreteTests
    {
        [Fact]
        public void TesteIntegridadeObjeto()
        {
            Frete frete = new Frete();
            frete.setCodigoServico("04014");
            frete.setCepOrigem("26985254"); //Não pode ser formatado
            frete.setCepDestino("26985254");
            frete.setPeso("2"); //Em quilogramas (kg)
            frete.setCodigoFormato(1); //1,2,3
            frete.setComprimento(12.6m);
            frete.setAltura(1.2m);
            frete.setLargura(2.3m);
            frete.setDiametro(5.6m);
            frete.setMaoPropria(false);
            frete.setValorDeclarado(2.3m);
            frete.setAvisoRecebimento(false);

            Assert.NotNull(frete);

        }

        [Fact]
        public void TesteUsandoMockCriarFrete()
        {
            Mock<ICorreioService> mock = new Mock<ICorreioService>();
            mock.Setup(m => m.CalculaFrete()).Returns(36.69);

            Frete frete = new Frete(mock.Object);
            double res = frete.CalculaFrete();

            Assert.Equal(36.69, res);
        }
    }
}
