using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelJuanApp.Domain.Entities
{
    public class Quarto : Entity
    {


        public int Numero { get; set; }

        public int QtePessoas { get; set; }

        public String Classificacao { get; set; }

        public Double ValorDiaria { get; set; }


        //Construtor Padrão
        public Quarto() { }


        //Construtor para Testes
        public Quarto(int numero, int qtePessoas, string classificacao, double valorDiaria)
        {
            Numero = numero;
            QtePessoas = qtePessoas;
            Classificacao = classificacao;
            ValorDiaria = valorDiaria;
        }
    }
}
