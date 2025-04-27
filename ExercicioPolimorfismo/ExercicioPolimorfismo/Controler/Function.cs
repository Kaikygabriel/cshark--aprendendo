using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using ExercicioPolimorfismo.Entity;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ExercicioPolimorfismo.Controler
{
    internal class Function
    {
        static List<Produto> produtos = new List<Produto>();
        public static void AdicionarProduto()
        {
            Console.WriteLine("Quantidade de produto :");
            int quantia = int.Parse(Console.ReadLine().Trim());
            for (int i = 1; i <= quantia; i++)
            {
                Console.Write("Comum,usado ou importado (c/u/i))");
                string selecao = Console.ReadLine();
                Console.WriteLine("Nome");
                string nome = Console.ReadLine();
                Console.WriteLine("Preço");
                double preco = double.Parse(Console.ReadLine());
                if (selecao.Equals("i", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Frete");   
                    double frete = double.Parse(Console.ReadLine());
                    produtos.Add(new ProdutoImportado(frete, nome, preco));
                }
                else if (selecao.Equals("u", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("data (dd/MM/yyyy)");
                    DateTime data = DateTime.Parse(Console.ReadLine());
                    produtos.Add(new ProdutoUsado(data, nome, preco));
                }
                else
                {
                    produtos.Add(new Produto(nome,preco));
                }
            }
            
        }
        public static void ListarProduto()
        {
            foreach(Produto p in produtos)
            {
                Console.WriteLine(p.Etiqueta()); 
            }
        }
    }
}
