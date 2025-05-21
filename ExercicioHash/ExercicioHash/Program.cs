using System;
using ExercicioHash.Entitie;
using ExercicioHash.Service;

namespace ExercicioHash
{
    internal class Program
    {
        static void Main()
        {
            string path = @"C:\Users\kaiky\Downloads\Usuarios.txt";
            ServicePath service = new ServicePath();
            List<string> list = service.Pegar(path);

            HashSet<Usuario> usuario = new HashSet<Usuario>();
            foreach(var l in list)
            {
                usuario.Add(new Usuario(l));
            }
            Console.WriteLine(usuario.Count);
            Ler<Usuario>(usuario);
        }
        public static void Ler<t>(IEnumerable<t>list)
        {
            foreach(t a in list)
            {
                Console.WriteLine(a);
            }
        }
    }
}
