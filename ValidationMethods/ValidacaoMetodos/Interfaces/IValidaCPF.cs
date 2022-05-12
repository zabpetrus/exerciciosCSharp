using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidacaoMetodos.Interfaces
{
    public interface IValidaCPF
    {
        public bool validaTamanhoCPF(string cpf);

        public bool validaNumeracaoCPF(string cpf);

        public bool validaSeSomenteNumeros(string cpf);
    }
}
