
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto4
{
    internal class Program
    {
        enum op {listar = 1, adicionar , remover,entrada,saida,sair }
        static void Main()
        {
            bool sair = false;
            while (sair == false)
            {
                Console.WriteLine("Sistema de Estoque \n 1 Listar \n 2 Adicionar \n 3 Remover \n 4 Entrada \n 5 Saida \n 6 Sair");
                op sele = (op)int.Parse(Console.ReadLine());
                if (sele > 0)
                {
                    switch (sele)
                    {
                        case op.adicionar:
                            break;
                        case op.remover:
                            break;
                        case op.saida:
                            break;
                        case op.entrada:

                            break;
                        case op.sair:
                            sair = true;
                            break;
                        default:
                            Console.WriteLine("error");
                            break;
                    }
                }
                else
                {
                    sair = true;
                }
            }
        }
        static void Cadastro()
        {
            Console.WriteLine("1- Curso \n 2 - Ebook \n 3 - Produto Fisico");
            int index = int.Parse(Console.ReadLine());
            if (index > 0 && index <= 3)
            {
                switch (index)
                {
                    case 1:
                        Curso.adicionar();
                        break;
                    case 2:
                        Ebook.adicionar();
                        break;
                    case 3:

                        break;
                    default:
                        Console.WriteLine("Nada encontrado");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Nada encontrado");
            }
        }
    }
}
