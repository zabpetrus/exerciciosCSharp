using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ValidacaoMetodos.Interfaces;

namespace ValidacaoMetodos.Validation
{
    public class ValidaCPF :IValidaCPF
    {
        public ValidaCPF() { }
       
        public bool validaNumeracaoCPF(string cpf)
        {
            FormatCPFValidation formatCPFValidation = new FormatCPFValidation(cpf);
            return formatCPFValidation.getResult();
        }

        public bool validaSeSomenteNumeros(string cpf)
        {
            return Regex.IsMatch(cpf, @"^\d+$");
        }

        public bool validaTamanhoCPF(string cpf)
        {
            return (cpf.Length == 11);
        }
    }
}
