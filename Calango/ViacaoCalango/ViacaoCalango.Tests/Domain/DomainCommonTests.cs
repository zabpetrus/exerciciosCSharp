using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViacaoCalango.Domain.Defaults;
using ViacaoCalango.Domain.Entities;
using Xunit;

namespace ViacaoCalango.Tests.Domain
{
    public class DomainCommonTests
    {
        [Fact]
        public void LugarTest1()
        {
            Rota rota = new Rota();
            rota.Id = 1;
            rota.Nome = "Rio / São Paulo";
            rota.Valor = 125.00f;

            Onibus onibus = new Onibus();
            onibus.Id = 23565; //Numero de serie
            onibus.RotaId = rota.Id;
            onibus.NumLugares = (int)Poltronas.Lugares.lugar_23;
            onibus.LugaresOcupados = 0;

            Trecho t2 = new Trecho();
            t2.TrechoName = "Meio";
            t2.TrechoId = 369; //Codigo geral do terminal
            t2.RotaID = rota.Id;
            t2.RotaPosicao = 1;
            Assert.NotNull(t2);

            Trecho t3 = new Trecho();
            t3.TrechoName = "Final";
            t3.TrechoId = 758; //Codigo geral do terminal
            t3.RotaID = rota.Id;
            t3.RotaPosicao = 2;

            Reserva reserva = new Reserva();
            reserva.PassageiroID = 1;
            reserva.RotaID = rota.Id;  //Select * from Rota where id = Rota.Id
            reserva.TrechoOrigem = t2.TrechoId; //Local de embarque
            reserva.TrechoDestino = t3.TrechoId;  //Local de desembarque
            reserva.Ida = true;
            reserva.Volta = true;
            reserva.Classe = Classes.Leito.Executivo.ToString();
            reserva.DataIda = DateTime.Now;
            reserva.DataVolta = DateTime.Now.AddDays(10);
            reserva.HoraEmbarque = DateTime.Now.AddHours(23);
            reserva.Valor = rota.Valor;

            Lugar lugar = new Lugar();
            lugar.Numero = 20; //Necessita validação: numero entre 1 e NumLugares
            lugar.OnibusId = onibus.Id;
            lugar.NumeroReserva = reserva.Id;
            Assert.NotNull(lugar);
        }

        [Fact]
        public void OnibusTest1()
        {
            Rota rota = new Rota();
            rota.Id = 1;
            rota.Nome = "Rio / São Paulo";
            rota.Valor = 125.00f;

            Onibus onibus = new Onibus();
            onibus.Id = 23565; //Numero de serie
            onibus.RotaId = rota.Id;
            onibus.NumLugares = (int)Poltronas.Lugares.lugar_23;
            onibus.LugaresOcupados = 0;
            Assert.NotNull(onibus);
        }

        [Fact]
        public void PagamentoTest1()
        {
            Passageiro passageiro = new Passageiro();
            passageiro.Id = 1;
            passageiro.Nome = "Leandro Tavares";
            passageiro.CPF = "65655565445";


            Pagamento pagamento = new Pagamento();
            pagamento.PassageiroID = passageiro.Id;
            pagamento.Status = true; //Pagamento feito
        }

        [Fact]
        public void ReservaTest1()
        {
            Rota rota = new Rota();
            rota.Id = 1;
            rota.Nome = "Rio / São Paulo";
            rota.Valor = 125.00f;

            Trecho t2 = new Trecho();
            t2.TrechoName = "Meio";
            t2.TrechoId = 369; //Codigo geral do terminal
            t2.RotaID = rota.Id;
            t2.RotaPosicao = 1;
            Assert.NotNull(t2);

            Trecho t3 = new Trecho();
            t3.TrechoName = "Final";
            t3.TrechoId = 758; //Codigo geral do terminal
            t3.RotaID = rota.Id;
            t3.RotaPosicao = 2;

            //Tem pre-reserva sem id
            Reserva reserva = new Reserva();
            reserva.PassageiroID = 1;
            reserva.RotaID = rota.Id;  //Select * from Rota where id = Rota.Id
            reserva.TrechoOrigem = t2.TrechoId; //Local de embarque
            reserva.TrechoDestino = t3.TrechoId;  //Local de desembarque
            reserva.Ida = true;
            reserva.Volta = true;
            reserva.Classe = Classes.Leito.Executivo.ToString();
            reserva.DataIda = DateTime.Now;
            reserva.DataVolta = DateTime.Now.AddDays(10);
            reserva.HoraEmbarque = DateTime.Now.AddHours(23);
            reserva.Valor = rota.Valor;

        }

        [Fact]
        public void RotaTest1()
        {
            Rota rota = new Rota();
            rota.Id = 1;
            rota.Nome = "Rio / São Paulo";
            rota.Valor = 125.00f;
            Assert.NotNull(rota);
        }

        [Fact]
        public void TrechoTest1()
        {
            Rota rota = new Rota();
            rota.Id = 1;
            rota.Nome = "Rio / São Paulo";
            rota.Valor = 125.00f;

            Trecho t1 = new Trecho();
            t1.TrechoName = "Inicio";
            t1.TrechoId = 365; //Codigo geral do terminal
            t1.RotaID = rota.Id;
            t1.RotaPosicao = 0;
            Assert.NotNull(t1);


            Trecho t2 = new Trecho();
            t2.TrechoName = "Meio";
            t2.TrechoId = 369; //Codigo geral do terminal
            t2.RotaID = rota.Id;
            t2.RotaPosicao = 1;
            Assert.NotNull(t2);

            Trecho t3 = new Trecho();
            t3.TrechoName = "Final";
            t3.TrechoId = 758; //Codigo geral do terminal
            t3.RotaID = rota.Id;
            t3.RotaPosicao = 2;
            Assert.NotNull(t3);
        }

        [Fact]
        public void PassageiroTest1()
        {
            Passageiro passageiro = new Passageiro();
            passageiro.Id = 1;
            passageiro.Nome = "Leandro Tavares";
            passageiro.CPF = "65655565445";
            Assert.NotNull(passageiro);
            
        }


    }
}
