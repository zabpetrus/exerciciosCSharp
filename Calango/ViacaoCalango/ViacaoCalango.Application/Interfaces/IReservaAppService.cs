using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViacaoCalango.Application.ViewModels;

namespace ViacaoCalango.Application.Interfaces
{
    public interface IReservaAppService
    {
        List<ReservaViewModel> GetAll();

        ReservaViewModel GetById(int id);

        bool Create(ReservaViewModel reservaViewModel);

        bool Update(int id, ReservaViewModel passageiro);

        bool Delete(int id);
    }
}
