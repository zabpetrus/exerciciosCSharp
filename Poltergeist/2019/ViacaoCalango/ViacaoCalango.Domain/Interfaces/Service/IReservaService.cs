using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViacaoCalango.Domain.Entity;

namespace ViacaoCalango.Domain.Interfaces.Service
{
    public interface IReservaService
    {
        public string GetOnibusDisponiveis(Onibus bus);

    }
}
