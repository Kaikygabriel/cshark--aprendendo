using System;

namespace ConsoleApp9
{   
   public class Menu
    {
        enum opcao { editar = 1,adicionar,excluir}
        public static void abrir()
        {
            Console.WriteLine("1-editar \n 2-adicionar \n 3-exluir");
            int index =  int.Parse(Console.ReadLine());
            Enum OpSelecionada = ((opcao)index);
            switch (OpSelecionada)
            { 
                  case opcao.editar:
                Console.WriteLine("Voce editou");
                    break;
                case opcao.adicionar:
                    Console.WriteLine("Voce adicionou");
                    break;
                case opcao.excluir:
                    Console.WriteLine("Voce excluiu");
                    break;
                default:
                    Console.WriteLine("ERROR, opcão não encontrada");
                    Console.Clear();
                    Program.Main();
                    break;
            }

        }
    }
    internal class Program
    {   
       
        public static void Main()
        {
            Console.WriteLine("deseja ir para o menu ? \n digite 1 para abrir");
            int valor = int.Parse(Console.ReadLine());
            switch (valor)
            {
                case 1:
                    Console.Clear();
                    Menu.abrir();
                    break;
                default:
                    Console.Clear();
                    Program.Main();
                    break;
            }
        }
    }
}
