using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ValidacaoMetodos.Interfaces;

namespace ValidacaoMetodos.Validation
{
    public class ValidarNome : IValidaNome
    {
        public bool validarCaracteresNome(string nome)
        {
            return Regex.IsMatch(nome, @"[\p{L} ]+$");         
        }

        public bool validarTamanhoNome(string nome)
        {
            return (nome == null || nome.Length > 5);
        }
    }
}
