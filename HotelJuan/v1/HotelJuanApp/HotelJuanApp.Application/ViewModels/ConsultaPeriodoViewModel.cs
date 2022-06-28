using System;

namespace HotelJuanApp.Application.ViewModels
{
    public class ConsultaPeriodoViewModel
    {
        public DateTime Checkin { get; set; }

        public DateTime Checkout { get; set; }

        public int QtePessoas { get;  set; }

        public ConsultaPeriodoViewModel(DateTime checkin, DateTime checkout, int qtePessoas)
        {
            Checkin = checkin;
            Checkout = checkout;
            QtePessoas = qtePessoas;
        }

        public ConsultaPeriodoViewModel()
        {
        }
    }
}
