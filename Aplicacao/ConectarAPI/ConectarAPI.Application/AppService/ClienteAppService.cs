using AutoMapper;
using ConectarAPI.Application.Interfaces;
using ConectarAPI.Application.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConectarAPI.Application.AppService
{
    public class ClienteAppService : IClienteAppService
    {
        
        public List<ClienteViewModel> GetAll()
        {
            List<ClienteViewModel> list = new List<ClienteViewModel>();
            return list;
        }
    }
}
