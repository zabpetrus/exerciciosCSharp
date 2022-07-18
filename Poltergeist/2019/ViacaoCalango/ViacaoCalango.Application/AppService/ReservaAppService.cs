using System;
using System.Collections.Generic;
using ViacaoCalango.Application.Interfaces;
using ViacaoCalango.Domain.Entity;

namespace ViacaoCalango.Application.AppService
{
    public class ReservaAppService : IReservaAppService    {

        private IReservaAppService _reservaAppService;
        public ReservaAppService(){}

        public ReservaAppService(IReservaAppService reservaAppService)
        {
            _reservaAppService = reservaAppService;
        }
         

        public List<string> GetOnibusDisponiveis(Onibus onibus)
        {
            string calango = onibus.LOnibus("RJ", "SP", 2, onibus.Rota, onibus.QtdPassageiros, 23);

            //var quartoVm = _mapper.Map<QuartoViewModel>(quartos.GetRange(0, 1));
            List<string> lstonibus = new List<string>();
            lstonibus.Add(calango);

            return lstonibus;
        }
    }
}
