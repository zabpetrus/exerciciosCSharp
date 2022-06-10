using Api.LojaoBazar.Application.AppService;
using Api.LojaoBazar.Application.Interfaces;
using Api.LojaoBazar.Application.ViewModel;
using Api.LojaoBazar.Domain.Entities;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Api.LojaoBazar.Tests.Application
{
    public class ClienteAppServiceTeste
    {
        [Fact]
        public void Test1()
        {

            Endereco endereco = new Endereco();
           // endereco.setClienteID(null);
            endereco.setRua("Rua Camargo Dias");
            endereco.setNumero(1235);
            endereco.setComplemento("casa");
            endereco.setCep("23659-888");

            ClienteCreateViewModel clienteCreateViewModel = new ClienteCreateViewModel();
            clienteCreateViewModel.nome = "Joel Carvalho";
            clienteCreateViewModel.endereco = endereco;
            clienteCreateViewModel.datanascimento = new DateTime(2015, 12, 25);
            clienteCreateViewModel.cpf = "256.875.469-87";
        

            ClienteResultViewModel clienteResultViewModel = new ClienteResultViewModel();
            clienteResultViewModel.Id = 1;
            clienteResultViewModel.cpf = "256.875.469-87";
            clienteResultViewModel.nome = "Joel Carvalho";
            clienteResultViewModel.endereco = endereco;
            clienteResultViewModel.datanascimento = new DateTime(2015, 12, 25);


            Mock<IClienteAppService> mock = new Mock<IClienteAppService>();
            mock.Setup(m => m.Create(clienteCreateViewModel)).Returns(clienteResultViewModel);

            ClienteAppService clienteAppService = new ClienteAppService(mock.Object);
            var result = clienteAppService.Create(clienteCreateViewModel);

            Assert.Equal(result, clienteResultViewModel);

        }
    }
}
