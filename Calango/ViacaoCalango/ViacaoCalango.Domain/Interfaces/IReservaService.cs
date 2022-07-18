using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViacaoCalango.Domain.Entities;

namespace ViacaoCalango.Domain.Interfaces
{
    public interface IReservaService
    {
        Reserva CriarReserva( int RotaID, string TrechoOrigem, string TrechoDestino, bool Ida, bool Volta, string Classe, DateTime DataIda, DateTime? DataVolta, DateTime HoraEmbarque, float Valor);
    }
}
