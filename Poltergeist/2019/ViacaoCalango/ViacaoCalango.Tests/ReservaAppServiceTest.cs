using Moq;
using System;
using System.Collections.Generic;
using ViacaoCalango.Application.AppService;
using ViacaoCalango.Application.ViewModel;
using ViacaoCalango.Domain.Entity;
using ViacaoCalango.Domain.Interfaces.Service;
using Xunit;

namespace ViacaoCalango.Tests
{
    public class ReservaAppServiceTest
    {
        [Fact]
        public void Test1()
        {
            string[,] rota1 = new string[4, 2];
            rota1[0, 0] = "ES";
            rota1[0, 1] = "6:00h";
            rota1[1, 0] = "BA";
            rota1[1, 1] = "8:00h";
            rota1[2, 0] = "SE";
            rota1[2, 1] = "10:00h";
            rota1[3, 0] = "AL";
            rota1[3, 1] = "12:00h";

            string[,] rota2 = new string[2, 2];
            rota2[0, 0] = "RJ";
            rota2[0, 1] = "6:00h";
            rota2[1, 0] = "SP";
            rota2[1, 1] = "8:00h";


            // string[] rota2 = { "ES", "BA", "SE", "AL"};

            Onibus bus = new Onibus(625, 23, 0, "Executivo", rota2);

            ConsultaRotasViewModel consulta = new ConsultaRotasViewModel(bus);

            List<Onibus> lOnibus = new List<Onibus>();

            Mock<IReservaService> mock = new Mock<IReservaService>();
            mock.Setup(m => m.GetOnibusDisponiveis(bus));
            ReservaAppService reservaApp = new ReservaAppService();
            // Act
            List<string> x = reservaApp.GetOnibusDisponiveis(bus);

            List<string> esperado = new List<String>();
            esperado.Add("horaSaida: 6:00h horaChegada: 8:00h Onibus: 625");

            // Assert
            Assert.Equal(esperado, x);
        }
    }
}
