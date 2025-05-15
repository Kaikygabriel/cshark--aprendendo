using System;
using Genericts.Service;

namespace Genericts
{
    public class Program
    {
        public static void Main(string[] args)
        {
            PrintService ps = new PrintService();
            List<int> valores = new List<int>();
            System.Console.WriteLine("Quantos numeros deseja adicionar");
            int numQuantidade = int.Parse(Console.ReadLine());
            for (int i = 1; i <= numQuantidade; i++)
            {
                int valor = int.Parse(Console.ReadLine());
                ps.Adicionar(valores, valor);
            }
            System.Console.WriteLine("");
            ps.GetList(valores);
              System.Console.WriteLine("");
            System.Console.WriteLine( ps.PrimerioNumero(valores));
        }
    }
}