using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaCarrinhoCompras.Entidade;

namespace SistemaCarrinhoCompras.Controler
{
    internal class Funcao
    {
        public class CarrinhoFuncao
        {
            public static void Adicionar()
            {
                Console.WriteLine("Quantidade de items");
                Console.WriteLine(new Produto());
                int quantidade = int.Parse(Console.ReadLine());
                Carrinho.AdicionarItem(quantidade);
            }
            public static void Listar()
            {
                Carrinho.ListarItems();
                Console.ReadLine();
            }
        }
    }
}
