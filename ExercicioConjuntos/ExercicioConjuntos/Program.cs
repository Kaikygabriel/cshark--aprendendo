using System;

namespace ExercicioConjuntos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> alunos = new HashSet<int>();

            Console.Write("curso um 1");
            int num = int.Parse(Console.ReadLine());
            for(int i = 1; i <= num; i++)
            {
                int idAluno= int.Parse(Console.ReadLine());
                alunos.Add(idAluno);
            }
            Console.Write("curso 2");
            int num2 = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num2; i++)
            {
                int idAluno = int.Parse(Console.ReadLine());
                alunos.Add(idAluno);
            }
            Console.Write("curso 3");
            int num3 = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num3; i++)
            {
                int idAluno = int.Parse(Console.ReadLine());
                alunos.Add(idAluno);
            }
            Console.WriteLine(alunos.Count);
        }
    }
}
