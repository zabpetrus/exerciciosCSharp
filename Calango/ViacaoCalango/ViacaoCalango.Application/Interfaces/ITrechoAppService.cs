using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViacaoCalango.Application.ViewModels;

namespace ViacaoCalango.Application.Interfaces
{
    public interface ITrechoAppService
    {
        List<TrechoViewModel> GetAll();

        TrechoViewModel GetById(int id);

        bool CreateTrecho(TrechoViewModel trecho);

        bool UpdateTrecho(int id, TrechoViewModel trecho);

        bool DeleteTrecho(int id);
    }
}
