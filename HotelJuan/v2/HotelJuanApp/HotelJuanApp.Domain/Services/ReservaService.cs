using HotelJuanApp.Domain.Entity;
using HotelJuanApp.Domain.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelJuanApp.Domain.Services
{
    public class ReservaService : IReservaService
    {

        private IReservaService _reservaService;

        public ReservaService()
        {
        }

        public ReservaService( IReservaService reservaService)
        {
            _reservaService = reservaService;
        }

        public List<Quarto> GetQuartosDisponiveis(DateTime dtinicio, DateTime dtfinal, int quantidade)
        {
            return _reservaService.GetQuartosDisponiveis(dtinicio, dtfinal, quantidade);
        }
    }
}
