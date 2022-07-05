using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViacaoCalango.Application.Interfaces;
using ViacaoCalango.Application.ViewModels;

namespace ViacaoCalango.Application.AppService
{
    public class RotaAppService : IRotaAppService
    {
        public readonly IRotaAppService _rotaAppService;

        public RotaAppService() { }


        public RotaAppService(IRotaAppService rotaAppService)
        {
            _rotaAppService = rotaAppService;
        }

        public bool CreateRoute(RotaViewModel route)
        {
            return _rotaAppService.CreateRoute(route);  
        }

        public bool DeleteRoute(int id)
        {
            return (_rotaAppService.DeleteRoute(id));   
        }

        public List<RotaViewModel> GetAllRoutes()
        {
            return _rotaAppService.GetAllRoutes();
        }

        public RotaViewModel GetRouteById(int id)
        {
            return _rotaAppService.GetRouteById(id);
        }

        public bool UpdateRoute(int id, RotaViewModel route)
        {
            return _rotaAppService.UpdateRoute(id, route);  
        }
    }
}
