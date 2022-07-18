using AutoMapper;
using ConectarAPI.Application.ViewModel;
using ConectarAPI.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConectarAPI.Infra.CrossCutting.Mapping
{
    public class ClienteProfile : Profile
    {
        public ClienteProfile()
        {
            CreateMap<Cliente, ClienteViewModel>();
            CreateMap<ClienteViewModel, Cliente>();
        }
    }
}
