using HotelJuanApp.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelJuanApp.Application.Interfaces
{
    public interface IReservaAppService
    {
        List< QuartoViewModel > GetQuartosDisponiveis(ConsultaPeriodoViewModel consulta);
    }
}
