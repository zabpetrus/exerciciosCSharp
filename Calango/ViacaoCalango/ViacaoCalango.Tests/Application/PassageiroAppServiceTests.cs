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
    public class PassageiroAppServiceTests
    {
        [Fact]
        public void getAllTests()
        {
            //Teste metodo List<PassageiroViewModel> GetAll();

            List<PassageiroViewModel> test = new List<PassageiroViewModel>();
            test.Add(new PassageiroViewModel("Juvenal Costa", "12345678985", "12/25/2001"));
            test.Add(new PassageiroViewModel("Carla Santana", "12546984555", "03/09/1987"));

            Mock<IPassageiroAppService> mock = new Mock<IPassageiroAppService>();
            mock.Setup(m => m.GetAll()).Returns(test);

            PassageiroAppService passageiroAppService = new PassageiroAppService(mock.Object);
            var lista = passageiroAppService.GetAll();

            Assert.Equal(test, lista);
        }

        [Fact]
        public void GetByIdTests()
        {
            //PassageiroViewModel GetById(int id);
            int id = 1;
            PassageiroViewModel passageiro = new PassageiroViewModel("Lord Donut", "23546878999", "12/25/5333");
            Mock<IPassageiroAppService> mock = new Mock<IPassageiroAppService>();
            mock.Setup(m => m.GetById(id)).Returns(passageiro);

            PassageiroAppService passageiroAppService = new PassageiroAppService(mock.Object);
            var obj = passageiroAppService.GetById(id);

            Assert.Equal(obj, passageiro);

        }

        [Fact]
        public void CreateTests()
        {
            //bool Create(PassageiroViewModel passageiroViewModel);
            var result = true;
            PassageiroViewModel passageiro = new PassageiroViewModel("Lord Donut", "23546878999", "12/25/5333");

            Mock<IPassageiroAppService> mock = new Mock<IPassageiroAppService>();
            mock.Setup(m => m.Create(passageiro)).Returns(result);

            PassageiroAppService passageiroAppService = new PassageiroAppService(mock.Object);
            var response = passageiroAppService.Create(passageiro);

            Assert.Equal(result, response); 

        }

        [Fact]
        public void UpdateTests()
        {
            //bool Update(int id, PassageiroViewModel passageiro);
            var result = true;
            int id = 1;
            PassageiroViewModel passageiro = new PassageiroViewModel("Lord Donut", "23546878999", "12/25/5333");

            Mock<IPassageiroAppService> mock = new Mock<IPassageiroAppService>();
            mock.Setup(m => m.Update(id, passageiro)).Returns(result);

            PassageiroAppService passageiroAppService = new PassageiroAppService(mock.Object);
            var response = passageiroAppService.Update(id, passageiro);

            Assert.Equal(result, response);
        }

        [Fact]
        public void DeleteTests()
        {
            //bool Delete(int id);
            int id = 1;
            var result = true;

            Mock<IPassageiroAppService> mock = new Mock<IPassageiroAppService>();
            mock.Setup(m => m.Delete(id)).Returns(result);

            PassageiroAppService passageiroAppService = new PassageiroAppService(mock.Object);
            var res = passageiroAppService.Delete(id);

            Assert.Equal(res, result);
        }
    }
}
