using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaNota
{
    internal class Program
    {
       public static List<aluno> mediaAluno = new List<aluno>();
        enum op {add = 1 ,ver}
        static void Main(string[] args)
        {
            bool sair = false;
            while (!sair)
            { 
               Console.WriteLine("Escolha uma das opçao \n 1- adicionar aluno \n 2- ver aluno");
               op sele = (op)int.Parse(Console.ReadLine());
              switch (sele) 
                {
                
            
                case op.add:
                    Console.Clear();
                    string nome = Console.ReadLine();
                    int media = int.Parse(Console.ReadLine());
                    mediaAluno.Add(new aluno(nome, media));
                    break;
                case op.ver:
                    Console.Clear();
                    aluno.exibir();
                    break;
                }
                Console.Clear();
            }
        }
    }
}
