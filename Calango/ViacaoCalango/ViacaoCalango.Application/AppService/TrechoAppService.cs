using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViacaoCalango.Application.Interfaces;
using ViacaoCalango.Application.ViewModels;

namespace ViacaoCalango.Application.AppService
{
    public class TrechoAppService : ITrechoAppService
    {

        private ITrechoAppService _trechoAppService;

        public TrechoAppService()
        {
        }

        public TrechoAppService(ITrechoAppService trechoAppService)
        {
            _trechoAppService = trechoAppService;
        }

        public bool CreateTrecho(TrechoViewModel trecho)
        {
            return _trechoAppService.CreateTrecho(trecho);
        }

        public bool DeleteTrecho(int id)
        {
            return (_trechoAppService.DeleteTrecho(id));    
        }

        public List<TrechoViewModel> GetAll()
        {
            return _trechoAppService.GetAll();
        }

        public TrechoViewModel GetById(int id)
        {
            return _trechoAppService.GetById(id);
        }

        public bool UpdateTrecho(int id, TrechoViewModel trecho)
        {
            return _trechoAppService.UpdateTrecho(id, trecho);
        }
    }
}
