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

        private IMapper _mapper;

        public ReservaAppService()
        {
        }

        public ReservaAppService( IReservaService reservaService, IMapper mapper )
        {
            _reservaService = reservaService;
            _mapper = mapper;
        }

        public List<QuartoViewModel> GetQuartosDisponiveis(ConsultaPeriodoViewModel consulta)
        {
            /* List<QuartoViewModel> lstQuartos = new List<QuartoViewModel>();
             QuartoViewModel qt = new QuartoViewModel(304, 2, "Standard", 202.66);
             lstQuartos.Add(qt);
             qt = new QuartoViewModel(369, 3, "Standard", 506.25);
             lstQuartos.Add(qt);
             return lstQuartos;*/


            //Quarto === QuartoViewModel
            var configuration = new MapperConfiguration(cfg => cfg.CreateMap<Quarto, QuartoViewModel>());

     
            //Input
            List<Quarto> quartos = _reservaService.GetQuartosDisponiveis(consulta.Checkin, consulta.Checkout, consulta.QtePessoas);
            if(quartos == null) { throw new Exception("Lista de Quartos Vazia");  }

            //output
            List<QuartoViewModel> quartosvm = _mapper.Map<List<Quarto>, List<QuartoViewModel>>(quartos); //Source -> Quarto .: Destino  -> QuartoViewModel
            if(quartosvm == null) { throw new Exception("Lista de QuartoViewModel Vazia"); }

            return quartosvm;
        }
    }
}
