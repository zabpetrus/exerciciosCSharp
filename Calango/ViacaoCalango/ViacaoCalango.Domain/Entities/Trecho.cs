using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViacaoCalango.Domain.Entities
{
    public class Trecho
    {
        public int TrechoId { get; set; }   

        public string TrechoName { get; set; }

        public int RotaID { get; set; }

        public int RotaPosicao { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Trecho trecho &&
                   TrechoId == trecho.TrechoId &&
                   TrechoName == trecho.TrechoName &&
                   RotaID == trecho.RotaID &&
                   RotaPosicao == trecho.RotaPosicao;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(TrechoId, TrechoName, RotaID, RotaPosicao);
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public Trecho(int trechoId, string trechoName, int rotaID, int rotaPosicao)
        {
            TrechoId = trechoId;
            TrechoName = trechoName;
            RotaID = rotaID;
            RotaPosicao = rotaPosicao;
        }

        public Trecho()
        {
        }
    }
}
