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

        public override bool Equals(object obj)
        {
            return obj is Lugar lugar &&
                   Numero == lugar.Numero &&
                   OnibusId == lugar.OnibusId &&
                   NumeroReserva == lugar.NumeroReserva;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Numero, OnibusId, NumeroReserva);
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
