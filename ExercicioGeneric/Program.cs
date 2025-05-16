using System;
using ExercicioGeneric.Service;

namespace ExercicioGeneric
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Repositorio<string> repo = new Repositorio<string>();
            string valor = Console.ReadLine();
            repo.Adicionar(valor);
            string valor2 = Console.ReadLine();
            repo.Adicionar(valor2);
            repo.Remover(valor);
            repo.GetLista();
            Console.ReadLine();
        }
    }
}
