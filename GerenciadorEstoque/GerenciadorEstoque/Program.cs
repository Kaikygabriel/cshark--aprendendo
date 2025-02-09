using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorEstoque
{
    internal class Program
    {
        enum op {adicionar = 1,ver,remover,sair}
        static void Main()
        {
            bool sair = false;
            while (!sair)
            {
                Console.WriteLine("Controle DE Estoque \n Digite uma das opção abaixo");
                Console.WriteLine("1-adicionar item \n 2-ver item \n 3-remover item \n4 - sair");
                op sele = (op)int.Parse(Console.ReadLine());
                switch (sele)
                {
                    case op.adicionar:
                        Console.Clear();
                        Loja.adicionar();
                        break;
                    case op.ver:
                        Console.Clear();
                        Loja.ver();
                        break;
                    case op.remover:
                        Console.Clear();
                        Loja.remover();
                        break;
                    case op.sair:
                        sair = true;
                        break;
                }
                Console.Clear();
            }
        }
    }
}
