using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViacaoCalango.Domain.Entity;

namespace ViacaoCalango.Application.ViewModel
{
    public class ConsultaRotasViewModel
    {
        public Onibus bus;

        public string LocalInicio { get; set; }

        public string LocalFinal { get; set; }

        public int Vagas { get; set; }

        public ConsultaRotasViewModel(string inicio, string fim, int vagas)
        {
            LocalInicio = inicio;
            LocalFinal = fim;
            Vagas = vagas;
        }

        public ConsultaRotasViewModel(Onibus bus)
        {
            this.bus = bus;
        }
    }
}
