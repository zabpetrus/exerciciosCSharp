using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.LojaoBazar.Domain.Entities
{
    public class Endereco
    {

        private int _Cliente;

        private string Rua;

        private int Numero;

        private string Complemento;

        private string Cep;



        public void setClienteID(int clienteID )
        {
            _Cliente = clienteID;
        }

        public void setNumero(int v)
        {
            Numero = v;
        }

        public void setRua(string v)
        {
            Rua = v;
        }

        public void setComplemento(string v)
        {
            Complemento = v;
        }

       
        public void setCep(string v)
        {
            Cep = v;
        }

       
    }
}
