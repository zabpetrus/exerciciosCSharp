using Api.LojaoBazar.Application.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.LojaoBazar.Application.Interfaces
{
    public interface IClienteAppService
    {
        public ClienteResultViewModel Create( ClienteCreateViewModel clienteCreateViewModel);

        public ClienteResultViewModel Get(int id);


    }
}
