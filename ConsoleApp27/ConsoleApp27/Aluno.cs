using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp27
{
    internal class Aluno:Usuario
    {
        public string turma;
        public Aluno(string turma,string nome,string email,string senha):base(nome,email,senha)
        {
            this.turma = turma;
        }
    }
}
