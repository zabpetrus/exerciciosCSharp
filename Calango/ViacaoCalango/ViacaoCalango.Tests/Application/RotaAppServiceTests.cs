using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViacaoCalango.Application.AppService;
using ViacaoCalango.Application.Interfaces;
using ViacaoCalango.Application.ViewModels;
using Xunit;

namespace ViacaoCalango.Tests.Application
{
    public class RotaAppServiceTests
    {
        [Fact]
        public void GetAllRoutesTests() {

          
            List<RotaViewModel> lista = new List<RotaViewModel>();
            RotaViewModel rotaViewModelA = new RotaViewModel("Jerry Lewis", "Rio de Janeiro", "São Paulo", 123.5f);
            lista.Add(rotaViewModelA);
            RotaViewModel rotaViewModelB = new RotaViewModel("Jerry Lewis", "Rio de Janeiro", "São Paulo", 123.5f);
            lista.Add(rotaViewModelB);


            Mock<IRotaAppService> mock = new Mock<IRotaAppService>();
            mock.Setup(m => m.GetAllRoutes()).Returns(lista);

            RotaAppService rotaAppService = new RotaAppService(mock.Object);
            var result = rotaAppService.GetAllRoutes();

            Assert.Equal(lista, result);
        }

        [Fact]
        public void GetRouteByIdTests() {

            int id = 1;
            RotaViewModel rotaViewModel = new RotaViewModel("Jerry Lewis", "Rio de Janeiro", "São Paulo", 123.5f);

            Mock<IRotaAppService> mock = new Mock<IRotaAppService>();
            mock.Setup(m => m.GetRouteById(id)).Returns(rotaViewModel);

            RotaAppService rotaAppService = new RotaAppService(mock.Object);
            var result = rotaAppService.GetRouteById(id);

            Assert.Equal(rotaViewModel, result);

        }

        [Fact]
        public void CreateRouteTests() {

            var status = true;
            RotaViewModel rotaViewModel = new RotaViewModel("Jerry Lewis", "Rio de Janeiro", "São Paulo", 123.5f);

            Mock<IRotaAppService> mock = new Mock<IRotaAppService>();
            mock.Setup(m => m.CreateRoute(rotaViewModel)).Returns(status);

            RotaAppService rotaAppService = new RotaAppService(mock.Object);
            var result = rotaAppService.CreateRoute(rotaViewModel);

            Assert.Equal(status, result);

        }

        [Fact]
        public void UpdateRouteTests() {

            int id = 1;
            var status = true;
            RotaViewModel rotaViewModel = new RotaViewModel("Jerry Lewis", "Rio de Janeiro", "São Paulo", 123.5f);

            Mock<IRotaAppService> mock = new Mock<IRotaAppService>();
            mock.Setup(m => m.UpdateRoute(id, rotaViewModel)).Returns(status);

            RotaAppService rotaAppService = new RotaAppService(mock.Object);
            var result = rotaAppService.UpdateRoute(id, rotaViewModel);

            Assert.Equal(status, result);

        }

        [Fact]
        public void DeleteRouteTests() {

            int id = 1;
            var status = true;

            Mock<IRotaAppService> mock = new Mock<IRotaAppService>();
            mock.Setup(m => m.DeleteRoute(id)).Returns(status);

            RotaAppService rotaAppService = new RotaAppService(mock.Object);
            var result = rotaAppService.DeleteRoute(id);

            Assert.Equal(status, result);
        }
    }
}
