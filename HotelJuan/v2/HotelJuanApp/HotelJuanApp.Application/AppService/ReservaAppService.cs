using AutoMapper;
using HotelJuanApp.Application.Interfaces;
using HotelJuanApp.Application.ViewModels;
using HotelJuanApp.Domain.Entity;
using HotelJuanApp.Domain.Interfaces.Service;
using HotelJuanApp.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelJuanApp.Application.AppService
{
    public class ReservaAppService : IReservaAppService
    {

        private IReservaService _reservaService;

      //  private IReservaAppService _reservaAppService;

        private readonly IMapper _mapper;

        public ReservaAppService(){ }

    
        public ReservaAppService( IMapper mapper, IReservaService reservaService )
        {             
            _mapper = mapper;
            _reservaService = reservaService;
        } 

        public List<QuartoViewModel> GetQuartosDisponiveis(ConsultaPeriodoViewModel consulta)
        {
            ReservaService reservaService = new ReservaService();
            List<Quarto> quartos = reservaService.GetQuartosDisponiveis(consulta.Checkin, consulta.Checkout, consulta.QtePessoas);

            //Input
            //List<Quarto> quartos = _reservaService.GetQuartosDisponiveis(consulta.Checkin, consulta.Checkout, consulta.QtePessoas);
            if(quartos == null) { throw new Exception("Lista de Quartos Vazia");  }

            //output
            //Not Working!!!!
            // List<QuartoViewModel> quartosvm = _mapper.Map<List<Quarto>, List<QuartoViewModel>>(quartos); //Source -> Quarto .: Destino  -> QuartoViewModel

            List<QuartoViewModel> quartosvm = new List<QuartoViewModel>();
            if (quartosvm == null) { throw new Exception("Lista de QuartoViewModel Vazia"); }


            return quartosvm;

        }
    }
}
