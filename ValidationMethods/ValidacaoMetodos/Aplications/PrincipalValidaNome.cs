using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValidacaoMetodos.Validation;

namespace ValidacaoMetodos.Aplications
{
    public class PrincipalValidaNome
    {
        public static void buildIn()
        {
            //Teste de validaNome
            string nome = "Pa5";
            ValidarNome validar = new ValidarNome();
            Console.WriteLine("O tamanho eh correto: " + validar.validarTamanhoNome(nome));
            Console.WriteLine("Os caracteres sao validos: " + validar.validarCaracteresNome(nome));

        }
    }
}

