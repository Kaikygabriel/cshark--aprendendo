using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FastFood.Entidades;

namespace FastFood.Controler
{
    internal class Funcao
    {
        static Cliente cliente ;
        public static void AdicionarCliente()
        {
            try
            {
                Console.WriteLine("Nome :");
                string nome = Console.ReadLine().Trim();
                Console.WriteLine("senha :");
                string senha = Console.ReadLine().Trim();
                cliente = new Cliente(nome, senha);

            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR");
                Console.ReadLine();
            }
        }
        public static void AdicionarProduto()
        {
            try
            {
                if(cliente.Nome != null && cliente != null)
                {
                    cliente.carrinho.AdicionarProduto();
                }
                else
                {
                    Console.WriteLine("Não a nenhum usuario");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("ERROR");
                Console.ReadLine();
            }
        }
        public static void ListarProdutos()
        {
            try
            {
                if (cliente.Nome != null && cliente != null)
                {
                    cliente.carrinho.ListaProduto();
                }
                else
                {
                    Console.WriteLine("Não a nenhum usuario");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR");
                Console.ReadLine();
            }
        }
    }
}
