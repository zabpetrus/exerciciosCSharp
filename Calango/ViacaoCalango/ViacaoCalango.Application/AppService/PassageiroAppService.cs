using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViacaoCalango.Application.Interfaces;
using ViacaoCalango.Application.ViewModels;

namespace ViacaoCalango.Application.AppService
{
    public class PassageiroAppService : IPassageiroAppService
    {
        private readonly IPassageiroAppService _passageiroAppService;

        public PassageiroAppService(IPassageiroAppService passageiroAppService)
        {
            _passageiroAppService = passageiroAppService;
        }

        public PassageiroAppService(){}

        public List<PassageiroViewModel> GetAll()
        {
            List<PassageiroViewModel> list = new List<PassageiroViewModel>();
            list.Add(new PassageiroViewModel("Juvenal Costa", "12345678985", "12/25/2001"));
            list.Add(new PassageiroViewModel("Carla Santana", "12546984555", "03/09/1987"));
            return list;
            
        }

        public PassageiroViewModel GetById(int id)
        {
            //PassageiroService passageiroService = new PassageiroService();
            return new PassageiroViewModel("Lord Donut", "23546878999", "12/25/5333");
        }

        public bool Create(PassageiroViewModel passageiroViewModel)
        {
            return true;
        }

        public bool Update(int id, PassageiroViewModel passageiro)
        {
            return true;
        }

        public bool Delete(int id)
        {
            return true;
        }


    }
}
