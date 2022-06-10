using Api.LojaoBazar.Application.AppService;
using Api.LojaoBazar.Application.Interfaces;
using Api.LojaoBazar.Application.ViewModel;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Api.LojaoBazar.Tests.Responses
{
    public class CadastrarCliente
    {
        [Fact]
        public void Test1()
        {
            ClienteResultViewModel clienteResultViewModel = new ClienteResultViewModel();
            clienteResultViewModel.Id = 4;
            clienteResultViewModel.nome = "Maria";
            clienteResultViewModel.datanascimento = new DateTime(1941,11,10);

            ClienteCreateViewModel clienteCreateViewModel = new ClienteCreateViewModel();
            clienteCreateViewModel.nome = "Paulo";
            clienteCreateViewModel.datanascimento = new DateTime(1941, 11, 10);


            Mock<IClienteAppService> mock = new Mock<IClienteAppService>();
            mock.Setup(m => m.Create(clienteCreateViewModel)).Returns(clienteResultViewModel);

            ClienteAppService clienteAppService = new ClienteAppService(mock.Object);
            var result = clienteAppService.Create(clienteCreateViewModel);

            Assert.Equal(clienteResultViewModel, result);
        }
    }
}
