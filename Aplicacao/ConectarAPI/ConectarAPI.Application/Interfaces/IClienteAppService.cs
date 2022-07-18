using ConectarAPI.Application.ViewModel;
using ConectarAPI.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConectarAPI.Application.Interfaces
{
    public interface IClienteAppService
    {
        List<ClienteViewModel> GetAll();
    }
}
