using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViacaoCalango.Application.ViewModels;

namespace ViacaoCalango.Application.Interfaces
{
    public interface IRotaAppService
    {
        List<RotaViewModel> GetAllRoutes();

        RotaViewModel GetRouteById(int id);

        bool CreateRoute(RotaViewModel route);  

        bool UpdateRoute(int id, RotaViewModel route);

        bool DeleteRoute(int id);
    }
}
