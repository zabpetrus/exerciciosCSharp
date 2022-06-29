using HotelJuanApp.Application;
using HotelJuanApp.Application.Interfaces;
using HotelJuanApp.Domain.Entity;
using HotelJuanApp.Domain.Interfaces.Service;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace HotelJuanApp.Tests.Application
{
    public class ReservaUnitest2
    {
        [Fact]
        public void Test1()
        {
            ConsultaPeriodoViewModel consulta = new ConsultaPeriodoViewModel(
                DateTime.Now.AddDays(2),
                DateTime.Now.AddDays(6),
                2);            

            List<Quarto> lstQuartos = new List<Quarto>();

            Quarto quarto = new Quarto(302, 2, "Standard", 125.69);
            lstQuartos.Add(quarto);

            quarto = new Quarto(369, 2, "Standard", 698.56);
            lstQuartos.Add(quarto);

            Mock<IReservaService> mock = new Mock<IReservaService>();
            mock.Setup(m => m.GetQuartosDisponiveis(consulta.Checkin, consulta.Checkout, consulta.QtePessoas)).Returns(lstQuartos);

            

           

           
        }
    }
}
