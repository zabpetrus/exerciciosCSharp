using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViacaoCalango.Domain.Entities
{
    public class Lugar
    {
        public Lugar()
        {
        }

        public int Numero { get; set; }
        public int OnibusId { get; set; }
        public int NumeroReserva { get; set; }

        public Lugar(int numero, int onibusId, int numeroReserva)
        {
            Numero = numero;
            OnibusId = onibusId;
            NumeroReserva = numeroReserva;
        }
    }
}
