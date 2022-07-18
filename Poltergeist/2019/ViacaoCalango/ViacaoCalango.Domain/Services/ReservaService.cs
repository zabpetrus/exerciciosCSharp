using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViacaoCalango.Domain.Entity;
using ViacaoCalango.Domain.Interfaces.Service;

namespace ViacaoCalango.Domain.Services
{
    public class ReservaService : IReservaService
    {

        private IReservaService _reservaService;

        public ReservaService(){ }

        public ReservaService(IReservaService reservaService)
        {
            _reservaService = reservaService;
        }

        public string GetOnibusDisponiveis(Onibus bus)
        {
            string resp = bus.LOnibus("RJ", "RJ", 2, bus.Rota, bus.QtdPassageiros, 23);
            return resp;
        }
    }
}
