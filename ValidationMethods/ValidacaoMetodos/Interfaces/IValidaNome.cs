using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidacaoMetodos.Interfaces
{
    public interface IValidaNome
    {
        bool validarTamanhoNome( string nome );
        bool validarCaracteresNome( string nome);

    }
}
