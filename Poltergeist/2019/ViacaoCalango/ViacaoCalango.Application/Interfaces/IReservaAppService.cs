using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViacaoCalango.Domain.Entity;

namespace ViacaoCalango.Application.Interfaces
{
    public interface IReservaAppService
    {
        public List<string> GetOnibusDisponiveis(Onibus onibus);
    }
}
