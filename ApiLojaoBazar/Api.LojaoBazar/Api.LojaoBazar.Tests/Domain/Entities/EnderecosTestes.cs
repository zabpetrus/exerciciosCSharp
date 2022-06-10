using Api.LojaoBazar.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Api.LojaoBazar.Tests.Domain.Entities
{
    public class EnderecosTestes
    {
        [Fact]
        public void Test1()
        {
            Cliente cliente = new Cliente();
            cliente.setId(1);
            cliente.setNome("João da Cunha");
            cliente.setEmail("joaocunha@gmail.com");
            cliente.setCpf("569.633.987-96");
            cliente.setStatus(true);
            cliente.setSenha("123456");


            Endereco endereco = new Endereco();
            endereco.setClienteID(cliente.getID());
            endereco.setRua("Rua Camargo Dias");
            endereco.setNumero(1235);
            endereco.setComplemento("casa");
            endereco.setCep("23659-888");

            Assert.NotNull(endereco);
        }
    }
}
