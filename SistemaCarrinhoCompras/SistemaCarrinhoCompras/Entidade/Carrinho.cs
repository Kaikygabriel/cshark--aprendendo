using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCarrinhoCompras.Entidade
{
    internal class Carrinho
    {
        static List<Item> items = new List<Item>();
        public static void AdicionarItem(int quantidade)
        {
            try
            {
                if (quantidade > 1)
                {
                    for (int i = 1; i <= quantidade; i++)
                    {
                        items.Add(new Produto());
                    }
                }
                else if(quantidade == 1)
                {
                    items.Add(new Produto());
                }
                else
                {
                    Console.WriteLine("ERROR , quantidade tem que ser maior que 0");
                    Console.WriteLine("escreva outro valor de quantidade");
                    int quantidade2 = int.Parse(Console.ReadLine());
                    Console.Clear();
                    AdicionarItem(quantidade2);
                }

            }
            catch(Exception e)
            {
                Console.WriteLine("ERROR");
            }
        }
        public static void ListarItems()
        {
            if(items.Count > 0)
            {
                foreach(Item item in items)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("ERROR Não tem item adicionado a lista");
            }
        }

    }
}
