using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ValidacaoMetodos.Validation
{
    internal class FormatCPFValidation
    {

        private bool ehValido = false;

        public FormatCPFValidation( String numero )
        {
            //Garantindo que a entrada tera somente numeros

            string cpf = String.Join("", Regex.Split(numero, @"[^\d]"));          

            //Os primeiros nove digitos

            string primeirosdigitos = cpf.Substring(0, cpf.Length-2);

            //Os dois ultimos dois numeros

            string ultimosdigitos = cpf.Substring(cpf.Length - 2);

            //Os primeiros nove digitos com o primeiro verificador

            string primeirosdigitospj = cpf.Substring(0, cpf.Length - 1);

            
           bool resultadoPrimeiroDigito = this.ValidarPrimeiroDigito(primeirosdigitos, ultimosdigitos);
           bool resultadoSegundoDigito = this.ValidarSegundoDigito(primeirosdigitospj, ultimosdigitos); 
            

           this.ehValido = (resultadoPrimeiroDigito && resultadoSegundoDigito);

           
        }

        private bool ValidarPrimeiroDigito( string primeirosdigitos, string ultimosdigitos )
        {
            //Verfificação do primeiro digito

            int contPD = 10; //Contador do primeiro digito
            int somaPd = 0;
            foreach (char c in primeirosdigitos)
            {
                somaPd = somaPd + (contPD * (int)Char.GetNumericValue(c));
                contPD -= 1;
            }
            int primeiroverificadorA = (int)Char.GetNumericValue(ultimosdigitos[0]); //Obtendo do mumero
            int primeiroverificadorB = 0;

            int restopd = ((somaPd * 10) % 11);
            if (restopd == 10)
            {
                primeiroverificadorB = 0;
            }
            else { primeiroverificadorB = restopd; }

            return (primeiroverificadorA == primeiroverificadorB);

        }

        private bool ValidarSegundoDigito( string primeirosdigitospj, string ultimosdigitos)
        {

            //Verfificação do segundo digito

            int contSD = 11;
            int somaSD = 0;


            foreach (char ch in primeirosdigitospj)
            {
                somaSD = somaSD + (contSD * (int)Char.GetNumericValue(ch));
                contSD -= 1;
            }
            int segundoverificadorA = (int)Char.GetNumericValue(ultimosdigitos[1]);
            int segundoverificadorB = 0;

            int restoSD = ((somaSD * 10) % 11);
            if (restoSD == 10)
            {
                segundoverificadorB = 0;
            }
            else { segundoverificadorB = restoSD; }

            return (segundoverificadorA == segundoverificadorB);

        }

        internal bool getResult()
        {
            return ehValido;
        }
    }
}
