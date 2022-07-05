using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViacaoCalango.Application.ViewModels;

namespace ViacaoCalango.Application.Interfaces
{
    public interface IPassageiroAppService
    {
        List<PassageiroViewModel> GetAll();

        PassageiroViewModel GetById(int id);

        bool Create(PassageiroViewModel passageiroViewModel);

        bool Update(int id, PassageiroViewModel passageiro);

        bool Delete(int id);

    }
}
