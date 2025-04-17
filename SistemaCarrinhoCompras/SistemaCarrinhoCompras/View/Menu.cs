using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaCarrinhoCompras.Controler;

namespace SistemaCarrinhoCompras.View
{
    internal class Menu
    {
       public static void Iniciar()
       {
            try
            {
                bool sair = true;
                while (sair)
                {
                    Console.WriteLine("Carrinho \n 1- Adicionar \n 2- Ver carrinho \n 3- sair");
                    int sele = int.Parse(Console.ReadLine());
                    switch (sele)
                    {
                        case 1:
                            Funcao.CarrinhoFuncao.Adicionar();
                            break;
                        case 2:
                            Funcao.CarrinhoFuncao.Listar();
                            break;
                        case 3:
                            sair = false;
                            break;
                        default:
                            Console.WriteLine("opção não encontrada escreva novamente");
                            break;
                    }
                    Console.Clear();
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("ERROR tente novamente");
                Console.ReadLine();
                Console.Clear();
                Iniciar();
            }
        }  
    }
}
