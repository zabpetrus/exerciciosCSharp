using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViacaoCalango.Domain.Entity
{
    public class Rota : Entity
    {
        public int Id { get; set; }
        public String Local { get; set; }
        public DateTimeOffset Hora { get; set; }

        public Rota(int id, string local, DateTimeOffset hora)
        {
            Id = id;
            Local = local;
            Hora = hora;
        }
    }
}
