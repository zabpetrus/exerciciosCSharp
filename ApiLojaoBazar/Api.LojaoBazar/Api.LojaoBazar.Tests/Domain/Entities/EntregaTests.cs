using Api.LojaoBazar.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Api.LojaoBazar.Tests.Domain.Entities
{
    public class EntregaTests
    {
        [Fact]
        public void Teste1()
        {
            Entrega entrega = new Entrega();
            entrega.setId(1);
            entrega.setStatus(false);

            Assert.NotNull(entrega);
        }

    }
}
