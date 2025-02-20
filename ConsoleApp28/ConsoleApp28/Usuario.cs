using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp28
{
    internal class Usuario
    {
        public string nome;
        public string email;
        public Usuario(string nome, string email )
        {
            this.nome = nome;
            this.email = email;
        }

          //virutal indica que esse metodo pode ser sobreescrito nas classes filhas
        public virtual void exibir()
        {
            Console.WriteLine("ola" + nome);
        }
        // cada elemento filho ter seu metodo exibir propio 
    }
}
