using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogos
{
    internal class Usuario
    {
        public string nome;
        public string email;
        public int senha;
       
        public void logar()
        {
            Console.WriteLine("logou");
        }
    }
    //aluno herda(:) de usuario 
    class Aluno : Usuario 
    {
        public List<string> turma = new List<string>();
        public string turno;
    }

}
