using HotelJuanApp.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelJuanApp.Domain.Entities
{
    public class Reserva
    {
        public DateTime Checkin { get; set; }

        public DateTime Checkout { get; set; }

        public int QtePessoas { get; set; }

        public Quarto NumQuarto { get; set; }

        public Reserva(DateTime checkin, DateTime checkout, int qtePessoas, Quarto numQuarto)
        {
            Checkin = checkin;
            Checkout = checkout;
            QtePessoas = qtePessoas;
            NumQuarto = numQuarto;
        }

       

    }
}
