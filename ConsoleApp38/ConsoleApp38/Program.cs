using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using loja;
namespace ConsoleApp38
{
    internal class Program
    {
        enum op {comprar = 1,ver,total,sair}
        static void Main(string[] args)
        {
            bool sair = false;
            while (!sair)
            {
                Console.WriteLine("1- comprar \n 2- carrinho \n 3-total\n4- sair");
                op sele = (op)int.Parse(Console.ReadLine());
                Console.Clear();
                switch (sele) 
                {
                    case op.comprar:
                        
                        loja.loja.Comprar();
                        break;
                    case op.ver:
                      
                        loja.loja.Ver();
                        break;
                    case op.total:
                        loja.loja.Total();
                        break;
                    case op.sair:
                        sair = true;
                        break;
                    default:
                        Console.WriteLine("nada encontrado");
                        break;
                }
                Console.Clear();

            }
        }
    }
}
