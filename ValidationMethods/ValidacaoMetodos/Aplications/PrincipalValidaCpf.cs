using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValidacaoMetodos.Validation;

namespace ValidacaoMetodos.Aplications
{
    public class PrincipalValidaCpf
    {
        public static void buildIn()
        {
            string cpf = "05714464770";
            ValidaCPF valida = new ValidaCPF();
            Console.WriteLine("Tamanho: " + valida.validaTamanhoCPF(cpf));
            Console.WriteLine("Valores: " + valida.validaSeSomenteNumeros(cpf));
            Console.WriteLine("Numeracao: " + valida.validaNumeracaoCPF(cpf));

        }
    }
}
