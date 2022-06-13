using BazarLojaApi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazarLojaApi.Domain.Interfaces
{
    public interface InterItensCarrinho
    {
        public void Create();

        public double Update();

        public ItensCarrinho GetById();

        public List<ItensCarrinho> GetAll();

        public double SimularFrete();

    }
}
