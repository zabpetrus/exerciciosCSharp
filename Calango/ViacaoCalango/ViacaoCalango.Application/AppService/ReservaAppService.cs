using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViacaoCalango.Application.Interfaces;
using ViacaoCalango.Application.ViewModels;
using ViacaoCalango.Domain.Defaults;

namespace ViacaoCalango.Application.AppService
{
    public class ReservaAppService : IReservaAppService
    {
        private readonly IReservaAppService _reservaAppService;

        public ReservaAppService(){}

        public ReservaAppService(IReservaAppService reservaAppService)
        {
            _reservaAppService = reservaAppService;
        }

        public bool Create(ReservaViewModel reservaViewModel)
        {
           return true;
        }

        public bool Delete(int id)
        {
            return true;
        }

        public List<ReservaViewModel> GetAll()
        {
            //public ReservaViewModel(int rotaID, int trechoOrigem, int trechoDestino, bool ida, bool volta, string classe, DateTime dataIda, DateTime dataVolta, DateTime horaEmbarque, float valor)

            List<ReservaViewModel> list = new List<ReservaViewModel>();
            list.Add(new ReservaViewModel(
                1, 1, 1, true, true, Classes.Leito.Executivo.ToString(), Convert.ToDateTime("20/06/2022"), Convert.ToDateTime("22/06/2022"), Convert.ToDateTime("1:20"), 20.66f
            ));
            list.Add(new ReservaViewModel(
                1, 1, 1, true, false, Classes.Leito.Semileito.ToString(), Convert.ToDateTime("01/09/2022"), Convert.ToDateTime("18/10/2022"), Convert.ToDateTime("1:20"), 20.66f
            ));;
            return list;
        }

        public ReservaViewModel GetById(int id)
        {
            ReservaViewModel reservaViewModel = new ReservaViewModel(
               1, 1, 1, true, true, Classes.Leito.Executivo.ToString(), Convert.ToDateTime("20/06/2022"), Convert.ToDateTime("22/06/2022"), Convert.ToDateTime("1:20"), 20.66f
            );
            return reservaViewModel;
        }

        public bool Update(int id, ReservaViewModel passageiro)
        {
            return true;
        }
    }
}
