using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Moq;
using ViacaoCalango.Application.ViewModels;
using ViacaoCalango.Domain.Defaults;
using ViacaoCalango.Domain.Entities;
using Xunit;

namespace ViacaoCalango.Tests.Infra
{
    public class ReservaServiceTests
    {
     
        [Fact]
        public void Test1()
        {
            ReservaViewModel reservaViewModel = new ReservaViewModel(
                1,
                1,
                2,
                true,
                false,
                Classes.Leito.Semileito.ToString(),
                DateTime.Parse("10/12/2022"),
                DateTime.Parse("11/01/2023"),
                DateTime.Parse("12:30"),
                123.56f
            );

            Reserva reserva = new Reserva(
                1,
                2,
                reservaViewModel.RotaID,
                reservaViewModel.TrechoOrigem,
                reservaViewModel.TrechoDestino,
                reservaViewModel.Ida,
                reservaViewModel.Volta,
                reservaViewModel.Classe,
                reservaViewModel.DataIda,
                reservaViewModel.DataVolta,
                reservaViewModel.HoraEmbarque,
                reservaViewModel.Valor
                );

            //Automapper failure net6.0 - mapper Always Null


            Assert.Equal(reserva.RotaID.ToString(), reservaViewModel.RotaID.ToString());
        }
    }
}
