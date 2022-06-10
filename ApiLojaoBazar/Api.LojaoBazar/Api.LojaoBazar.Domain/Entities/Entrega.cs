using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.LojaoBazar.Domain.Entities
{
    public class Entrega
    {
        private int Id { get; set; }

        private bool Status { get; set; }

        public void setId(int v) { Id = v; }       

        public void setStatus(bool v) { Status = v; }

        public int getId() { return Id; }

        public bool getStatus() { return Status; }
      
    }
}
