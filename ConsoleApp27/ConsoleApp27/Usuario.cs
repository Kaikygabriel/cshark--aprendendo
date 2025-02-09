using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp27
{
    internal class Usuario
    {
        protected string nome;
        protected string email;
        protected string senha;

        public Usuario(string nome, string email, string senha)
        {
            if (nome.Length > 1 && email.Length > 1 && senha.Length > 1)
            {
                this.nome = nome;
                this.email = email;
                this.senha = senha;
            }
        }
        public void exibir()
        {
            Console.WriteLine("O  "+nome+" , entrou");
        }
    }
}
