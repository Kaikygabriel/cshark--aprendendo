using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turmas.Entidade
{
    internal class Turma
    {
        public List<Aluno> alunos = new List<Aluno>();
        //Construtor vazio abaixo
        public Turma(){ }
        public void AdicionarAluno()
        {
            try
            {
                Console.WriteLine("Nome do aluno :");
                string nome = Console.ReadLine();
                Console.WriteLine("Nota");
                float nota = float.Parse(Console.ReadLine());
                Console.WriteLine("Idade");
                int idade = int.Parse(Console.ReadLine());
                alunos.Add(new Aluno(nome, idade, nota));
            }
            catch (Exception ex)
            {
                Console.Clear();
                AdicionarAluno();
            }
        }
        public void ListarAluno()
        {
            if (alunos.Count > 0)
            {
                foreach(Aluno a in alunos)
                {
                    Console.WriteLine(a);
                }
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("ERROR sem alunos na lista");
                Console.Clear();
            }
        }
    }
}
