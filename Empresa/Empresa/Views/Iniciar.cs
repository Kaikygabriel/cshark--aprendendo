using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Empresa.Controler;

namespace Empresa.Views
{
    internal class Iniciar
    {
        public static void IniciarTela1()
        {
            bool sair = true;
            while(sair)
            {
                try
                {
                    Console.WriteLine("BEM VINDO AO GERENCIADOR DE FUNCIONARIOS \n1- gerentes \n2- vendedores \n3-sair ");
                    int selecao = int.Parse(Console.ReadLine());
                    switch (selecao)
                    {
                        case 1:
                            TelaGerente();
                            break;
                        case 2:
                            TelaVendedor();
                            break;
                        case 3:
                            sair = false;
                            break;
                        default:
                            Console.WriteLine("ERROR tente novamente");
                            Console.Clear();
                            IniciarTela1();
                            break;
                    }
                    Console.Clear();
                }
                catch (Exception e)
                {
                    Console.WriteLine("ERROR tente novamente");
                    Console.Clear();
                    IniciarTela1();
                }
            }
           
        }
        private static void TelaGerente()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("1- adicionar gerente \n 2- pagar gerente");
                int selecao = int.Parse(Console.ReadLine());
                switch (selecao)
                {

                    case 1:
                        GerenteFuncao.AdicionarGerente();
                        break;
                    case 2:
                        GerenteFuncao.PagarGerente();
                        break;

                    default:
                        Console.WriteLine("ERROR tente novamente");
                        Console.Clear();
                        TelaGerente();
                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR tente novamente");
                Console.Clear();
                TelaGerente();
            }
        }
        private static void TelaVendedor()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("1- adicionar vendedor \n 2- pagar vendedor");
                int selecao = int.Parse(Console.ReadLine());
                switch (selecao)
                {

                    case 1:
                        VendedorFuncao.AdicionarVendedor();
                        break;
                    case 2:
                        VendedorFuncao.PagarVendedor();
                        break;

                    default:
                        Console.WriteLine("ERROR tente novamente");
                        Console.Clear();
                        TelaGerente();
                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR tente novamente");
                Console.Clear();
                TelaGerente();
            }
        }
    }
}


