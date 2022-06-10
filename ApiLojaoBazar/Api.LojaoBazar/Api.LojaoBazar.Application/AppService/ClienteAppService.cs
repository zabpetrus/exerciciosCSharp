using Api.LojaoBazar.Application.Interfaces;
using Api.LojaoBazar.Application.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.LojaoBazar.Application.AppService
{
    public class ClienteAppService
    {

        private IClienteAppService _clienteAppService;

        public ClienteAppService() {}

        public ClienteAppService( IClienteAppService clienteAppService )
        {
            _clienteAppService = clienteAppService;
        }

        public ClienteResultViewModel Create(ClienteCreateViewModel clienteCreateViewModel)
        {
            return _clienteAppService.Create(clienteCreateViewModel);
        }

        public ClienteResultViewModel Get(int id)
        {
            return _clienteAppService.Get(id);
        }


    }
}
