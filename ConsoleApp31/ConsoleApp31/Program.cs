using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp31
{
    internal class Program
    {
        enum op {ver =1,add,sair}
        static void Main()
        {

            bool sair = false;
            while (!sair)
            {

                Console.WriteLine("escolha uma das opção abaixo \n 1-ver\n 2-adicionar\n3-sair");
                op sele = (op)int.Parse(Console.ReadLine());
                Console.Clear();
                switch (sele) 
                {
                    case op.add:
                        Estoque.Adicionar();

                        break;
                    case op.ver:
                        Estoque.ver();
                        break;
                    case op.sair:
                        sair = true;
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
                Console.Clear();
            }
        }
    }
}
