using BazarLojaApi.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazarLojaApi.Domain.Entities
{
    public class ItensCarrinho : InterItensCarrinho
    {
        public int Id { get; set; }
        public int IdCarrinho { get; set; }
        public int IdProduto { get; set; }
        public int Quantidade { get; set; }
        public double Preco { get; set; }
        public string NomeProduto { get; set; }

        public InterItensCarrinho _interItensCarrinho; //Criando uma interface para os testes

        //Gerar Construtores conforme está no esquema
        public ItensCarrinho() { }

        public ItensCarrinho( InterItensCarrinho interItensCarrinho)
        {
            _interItensCarrinho = interItensCarrinho;

        }

        //Implementação dos Métodos para usar o Mock

        public void Create()
        {
            _interItensCarrinho.Create();
        }

        public double Update()
        {
           return _interItensCarrinho.Update();
        }

        public ItensCarrinho GetById()
        {
            return _interItensCarrinho.GetById();
        }

        public List<ItensCarrinho> GetAll()
        {
            return _interItensCarrinho.GetAll();
        }

        public double SimularFrete()
        {
            return _interItensCarrinho.SimularFrete();
        }
    }
}
