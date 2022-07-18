// See https://aka.ms/new-console-template for more information
using ViacaoCalango.Application.AppService;
using ViacaoCalango.Application.ViewModels;
using ViacaoCalango.Domain.Defaults;
using ViacaoCalango.Domain.Entities;

Console.WriteLine("Hello, World!");

Rota rota = new Rota();
rota.Id = 1;
rota.Nome = "Rio / São Paulo";
rota.Valor = 125.00f;

//Select * from Trecho Where RotaID = Rota.Id

Trecho t1 = new Trecho();
t1.TrechoName = "Inicio";
t1.TrechoId = 365; //Codigo geral do terminal
t1.RotaID = rota.Id;
t1.RotaPosicao = 0;


Trecho t2 = new Trecho();
t2.TrechoName = "Meio";
t2.TrechoId = 369; //Codigo geral do terminal
t2.RotaID = rota.Id;
t2.RotaPosicao = 1;


Trecho t3 = new Trecho();
t3.TrechoName = "Final";
t3.TrechoId = 758; //Codigo geral do terminal
t3.RotaID = rota.Id;
t3.RotaPosicao = 2;


Onibus onibus = new Onibus();
onibus.Id = 23565; //Numero de serie
onibus.RotaId = rota.Id;
onibus.NumLugares = (int) Poltronas.Lugares.lugar_23;
onibus.LugaresOcupados = 0;


Passageiro passageiro = new Passageiro();
passageiro.Id = 1;
passageiro.Nome = "Leandro Tavares";
passageiro.CPF = "65655565445";


Pagamento pagamento = new Pagamento();  
pagamento.PassageiroID = passageiro.Id;
pagamento.Status = true; //Pagamento feito


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



Lugar lugar = new Lugar();
lugar.Numero = 20; //Necessita validação: numero entre 1 e NumLugares
lugar.OnibusId = onibus.Id;
lugar.NumeroReserva = reserva.Id;



//ReservaViewModel é a Pré-Reserva
ReservaViewModel reservaViewModel = new ReservaViewModel();
reservaViewModel.RotaID = rota.Id;  //Select * from Rota where id = Rota.Id
reservaViewModel.TrechoOrigem = t2.TrechoId; //Local de embarque
reservaViewModel.TrechoDestino = t3.TrechoId;  //Local de desembarque
reservaViewModel.Classe = Classes.Leito.Executivo.ToString().ToLower();
reservaViewModel.Ida = true;
reservaViewModel.Volta = true;
reservaViewModel.DataIda = DateTime.Now;
reservaViewModel.DataVolta = DateTime.Now.AddDays(10);
reservaViewModel.HoraEmbarque = DateTime.Now.AddHours(10);
reservaViewModel.Valor = rota.Valor;

Console.WriteLine("ReservaViewModel: " + reservaViewModel.toString());

//Calculando a quantidade de bancos:

/*
 ----------------------------------------- Rota Rio / Sampa ----------------------------------------
 Terminal Grande Rio (RJ) ------ Parada 1:Camboriú ------ Parada 2:JardimVerde ------ Terminal Tietê
----------------------------------------------------------------------------------------------------
 */

var qtelugares = onibus.NumLugares;
List<Lugar> listadelugares = new List<Lugar>(qtelugares); //A lista com o total

Reserva r2 = new Reserva();
r2.TrechoOrigem = t1.TrechoId; //Reserva feita no Inicio

Reserva r1 = new Reserva();
r2.TrechoOrigem = t2.TrechoId; //Reserva feita no Meio


//Comprando no Inicio: lugar : int numero, int onibusId, int numeroReserva
listadelugares.Add(new Lugar(23, onibus.Id, r1.Id)); //Tabela LugaresDisponiveisOnibus
onibus.LugaresOcupados += 1;

//Comprando no Meio: lugar : int numero, int onibusId, int numeroReserva
listadelugares.Add(new Lugar(36, onibus.Id, r2.Id));
onibus.LugaresOcupados += 1;


var lugaresdisponiveis = onibus.NumLugares - onibus.LugaresOcupados;

Console.WriteLine("Busão: ");
Console.WriteLine("ID: " + onibus.Id + "\nRota: " + onibus.RotaId );
Console.WriteLine("Total lugares: " + onibus.NumLugares + "\nLugares Livres: " + lugaresdisponiveis + "\nLugares ocupados: " + onibus.LugaresOcupados);

PassageiroAppService passageiroAppService = new PassageiroAppService();
var listadePassageiros = passageiroAppService.GetAll();
List<string> k = listadePassageiros.Select(s => s.toString()).ToList();

foreach(string pass in k)
{
    Console.WriteLine( pass );
}

//Comprando no terminal

//Rota -> Rio / São Paulo
//Trecho 0 -> Terminal Novo Rio
//Onibus 65589 - Partida 12:00 - Plataforma F1
//Assento 44
//Pegou no terminal e vai soltar no Trecho 4
//Lugaresonibus -1

List<Partida> listaPartidas = new List<Partida>();
listaPartidas.Add(new Partida(1, "Onibus", "Rio/São-Paulo", "Terminal G1", "12/06/2022", "15:00"));




















