using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.LojaoBazar.Domain.Entities
{
    public class Cliente
    {
        private int Id { get; set; }

        private string Nome { get; set; }

        private string Email { get; set; }

        private string Cpf { get; set; }

        private bool Status { get; set; }         

        private string Senha { get; set; }


        public void setId(int v)
        {
            Id = v;
        }

        public void setNome(string v)
        {
            Nome = v;
        }

        public void setStatus(bool v)
        {
            Status = v;
        }        

        public void setSenha(string v)
        {
            Senha = v;
        }

        public void setCpf(string v)
        {
            Cpf = v;
        }

        public void setEmail(string v)
        {
            Email = v;
        }



        public int getID()
        {
            return Id;
        }

        public string getNome(string v)
        {
            return Nome;
        }

        public bool getStatus()
        {
            return Status;
        }

        public string getSenha()
        {
           return Senha;
        }

        public string getCpf()
        {
            return Cpf;
        }

        public string getEmail()
        {
            return Email;
        }


    }
}
