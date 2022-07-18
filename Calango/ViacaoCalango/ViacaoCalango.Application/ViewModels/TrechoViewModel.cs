using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViacaoCalango.Application.ViewModels
{
    public class TrechoViewModel : IEquatable<TrechoViewModel>
    {
        public TrechoViewModel()
        {
        }

        public string TrechoName { get; set; }

        public int RotaID { get; set; }

        public int RotaPosicao { get; set; }

        public TrechoViewModel(string trechoName, int rotaID, int rotaPosicao)
        {
            TrechoName = trechoName;
            RotaID = rotaID;
            RotaPosicao = rotaPosicao;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as TrechoViewModel);
        }

        public bool Equals(TrechoViewModel other)
        {
            return other is not null &&
                   TrechoName == other.TrechoName &&
                   RotaID == other.RotaID &&
                   RotaPosicao == other.RotaPosicao;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(TrechoName, RotaID, RotaPosicao);
        }

        public string toString()
        {
            return this.TrechoName + this.RotaPosicao + this.RotaID;
        }
    }
}
