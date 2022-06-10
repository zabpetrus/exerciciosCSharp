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
    public class FazerPagamento
    {
        [Fact]
        public void Test1()
        {
            Cliente cliente = new Cliente();
            cliente.setId(1);

            Mock<IPagamentoService> mock = new Mock<IPagamentoService>();
            mock.Setup(m => m.GetPagamento(cliente.getID())).Returns(true);

            Pagamento pagamento = new Pagamento(mock.Object);
            var res = pagamento.GetPagamento(cliente.getID());

            Assert.True(res);

        }
    }
}
