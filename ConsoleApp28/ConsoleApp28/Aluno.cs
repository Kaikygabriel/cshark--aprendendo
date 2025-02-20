using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp28
{
    internal class Aluno :Usuario
    {
        public Aluno(string nome,string email):base(nome, email) { }    
        //override significa sobrepor -- sobreescrever
        public override void exibir()
        {
            //base seria a class pai
            //executa o codigo da class pai
            base.exibir();
            Console.WriteLine("bem vindo aluno");
        }
    }
}
