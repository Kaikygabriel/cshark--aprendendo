using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOja
{
    internal class Program
    {
        enum opestoque {ver =1,add,remove}
        enum op{Loja= 1, estoque}
        static void Main()
        {
            Console.WriteLine("Gerenciador de lOJA \n 1- Loja \n 2-estoque");
            op sele = (op)int.Parse(Console.ReadLine());
            switch (sele) 
            {
                case op.Loja:
                    Console.Clear();
                    Console.WriteLine("1- adicionar \n 2- ver produto");
                    break;
                case op.estoque:
                    Console.Clear();
                    Console.WriteLine("1-ver estoque \n 2- adicioanr\n3-remove");
                    opestoque seleestoque = (opestoque)int.Parse(Console.ReadLine());
                    switch (seleestoque) 
                    {
                        case opestoque.add:
                            Estoque.adicionarArmazen();
                            break;
                        case opestoque.ver:
                            Estoque.VerArmazen();
                            break;
                        case opestoque.remove:
                            Estoque.RemoveEstoque();
                            break;
                    }

                    break;
            }

        }
    }
}
