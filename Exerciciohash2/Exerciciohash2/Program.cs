using System;
using Exerciciohash2.Entities;
using Exerciciohash2.Service;

namespace Exerciciohash2
{
    internal class Program
    {
        static void Main()
        {
            string path = @"C:\Users\kaiky\Downloads\Usuarios.txt";
            IRepositor repositor = new ServiceRepositorio();
            List<string> list = repositor.Fazer(path);
            HashSet<Usuario> usuarios = new HashSet<Usuario>();
            foreach(var a in list)
            {
                usuarios.Add(new Usuario(a));
            }
            Console.WriteLine(usuarios.Count);
            Ler<Usuario>(usuarios);
        }
        static void Ler<T> (IEnumerable<T> list)  
        {
            foreach (var a in list)
            {
                Console.WriteLine(a);
            }
        }
    }
}
