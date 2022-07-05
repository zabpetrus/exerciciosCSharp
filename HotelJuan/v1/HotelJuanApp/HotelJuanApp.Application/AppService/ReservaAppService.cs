using HotelJuanApp.Application.Interfaces;
using HotelJuanApp.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelJuanApp.Application.AppService
{
    public class ReservaAppService : IReservaAppService
    {
        public List<QuartoViewModel> GetQuartosDisponiveis(ConsultaPeriodoViewModel consulta)
        {
            List<QuartoViewModel> list = new List<QuartoViewModel>();
            list.Add(new QuartoViewModel(200, 2, "Standard", 2.5d));
            return list;
        }
    }
}
