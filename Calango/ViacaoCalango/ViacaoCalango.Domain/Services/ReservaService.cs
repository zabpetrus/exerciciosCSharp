using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViacaoCalango.Domain.Entities;
using AutoMapper;

namespace ViacaoCalango.Domain.Services
{
    public class ReservaService
    {
        private IMapper _mapper;

        public ReservaService(){}

          
        public List<Reserva> listaReservas()
        {
            
            List<Reserva> reservaList = new List<Reserva>();
            return reservaList;
        }

        public void ComprarPassagens( Rota rota, Trecho trecho )
        {

        }
    }
}
