using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViacaoCalango.Domain.Entities
{
    public class Onibus
    {
        public int Id { get; set; }             

        public int RotaId { get; set; }

        public int NumLugares { get; set; }

        public int LugaresOcupados { get; set; } = 0;

        public Onibus(int id, int rotaId, int numLugares, int lugaresOcupados)
        {
            Id = id;
            RotaId = rotaId;
            NumLugares = numLugares;
            LugaresOcupados = lugaresOcupados;
        }

        public Onibus()
        {
        }
    }
}
