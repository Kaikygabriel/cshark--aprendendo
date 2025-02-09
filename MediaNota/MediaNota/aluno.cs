using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaNota
{
    [System.Serializable]
    internal class aluno
    {
        private string nome;
        private int nota;
        public aluno(string nome,int nota)  
        {
            if(nome != null && nome.Length >= 1)
            {
                this.nome = nome;
            }
            if (nota >= 1 && nota != null && nota <= 10) 
            {
                this.nota = nota;
            }
        }
        public static void exibir()
        {
            foreach(aluno a in Program.mediaAluno)
            {
                if(a.nota >= 5)
                {
                    Console.WriteLine($"O aluno {a.nome},tirou nota {a.nota}, Aluno Aprovado");
                }
                else
                {
                    Console.WriteLine($"O aluno {a.nome},tirou nota {a.nota}, Aluno Reprovado");
                    
                }
               
            }
           Console.ReadLine();
        }
    }
}

