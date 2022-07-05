using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViacaoCalango.Application.AppService;
using ViacaoCalango.Application.Interfaces;
using ViacaoCalango.Application.ViewModels;
using ViacaoCalango.Domain.Defaults;
using Xunit;

namespace ViacaoCalango.Tests.Application
{
    public class ReservaAppServiceTests
    {
        [Fact]
        public void GetAllTests()
        {
            List<ReservaViewModel> list = new List<ReservaViewModel>();
            list.Add(new ReservaViewModel(
                1, 1, 1, true, true, Classes.Leito.Executivo.ToString(), Convert.ToDateTime("20/06/2022"), Convert.ToDateTime("22/06/2022"), Convert.ToDateTime("1:20"), 20.66f
            ));
            list.Add(new ReservaViewModel(
                1, 1, 1, true, false, Classes.Leito.Semileito.ToString(), Convert.ToDateTime("01/09/2022"), Convert.ToDateTime("18/10/2022"), Convert.ToDateTime("1:20"), 20.66f
            )); ;


            Mock<IReservaAppService> mock = new Mock<IReservaAppService>();
            mock.Setup(m => m.GetAll()).Returns(list);

            ReservaAppService reservaAppService = new ReservaAppService(mock.Object);
            var result = reservaAppService.GetAll();
            Assert.Equal(result, list);
        }

        [Fact]
        public void GetByIdTests()
        {
            int id = 1;
            ReservaViewModel reservaViewModel = new ReservaViewModel(
               1, 1, 1, true, true, Classes.Leito.Executivo.ToString(), Convert.ToDateTime("20/06/2022"), Convert.ToDateTime("22/06/2022"), Convert.ToDateTime("1:20"), 20.66f
            );

            Mock<IReservaAppService> mock = new Mock<IReservaAppService>();
            mock.Setup(m => m.GetById(id)).Returns(reservaViewModel);

            ReservaAppService reservaAppService = new ReservaAppService(mock.Object);
            var t = reservaAppService.GetById(id);
            Assert.Equal(reservaViewModel, t);
        }

        [Fact]
        public void CreateTests()
        {
            bool result = true;
            ReservaViewModel reservaViewModel = new ReservaViewModel(
               1, 1, 1, true, true, Classes.Leito.Executivo.ToString(), Convert.ToDateTime("20/06/2022"), Convert.ToDateTime("22/06/2022"), Convert.ToDateTime("1:20"), 20.66f
            );

            Mock<IReservaAppService> mock = new Mock<IReservaAppService>();
            mock.Setup(m => m.Create(reservaViewModel)).Returns(result);

            ReservaAppService reservaAppService = new ReservaAppService(mock.Object);
            var t = reservaAppService.Create(reservaViewModel);
            Assert.Equal(t, result);
        }

        [Fact]
        public void UpdateTests()
        {
            int id = 1;
            bool result = true;
            ReservaViewModel reservaViewModel = new ReservaViewModel(
               1, 1, 1, true, true, Classes.Leito.Executivo.ToString(), Convert.ToDateTime("20/06/2022"), Convert.ToDateTime("22/06/2022"), Convert.ToDateTime("1:20"), 20.66f
            );

            Mock<IReservaAppService> mock = new Mock<IReservaAppService>();
            mock.Setup(m => m.Update(id, reservaViewModel)).Returns(result);    

            ReservaAppService reservaAppService = new ReservaAppService(mock.Object);
            var t = reservaAppService.Update(id, reservaViewModel);
            Assert.Equal(t, result);
        }

        [Fact]
        public void DeleteTests()
        {
            int id = 1;
            bool result = true;
        

            Mock<IReservaAppService> mock = new Mock<IReservaAppService>();
            mock.Setup(m => m.Delete(id)).Returns(result);

            ReservaAppService reservaAppService = new ReservaAppService(mock.Object);
            var t = reservaAppService.Delete(id);   

            Assert.Equal(t, result);
        }
    }
}
