using HotelJuanApp.Domain.Entity;
using HotelJuanApp.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelJuanApp.Domain.Entities
{
    public class Cliente : EntityDom, IAppServiceBase<Cliente>
    {
        public int Id { get; set; }

        public String Nome { get; set; }

        public String DatadeNascimento { get; set; }

        public String CPF { get; set; }

        public void Add(Cliente obj)
        {
            throw new NotImplementedException();
        }

        public List<Cliente> GetAll()
        {
            throw new NotImplementedException();
        }

        public Cliente GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(Cliente obj)
        {
            throw new NotImplementedException();
        }

        public void Update(Cliente obj)
        {
            throw new NotImplementedException();
        }
    }
}
