using System;

namespace ConsoleApp12
{
    public class Mudar
    {
        public static void Converter()
        {
            Console.Clear();
            Console.WriteLine("Escreva um Numero para ele converter  EM STRING CARA!!!!!");
            int num = int.Parse(Console.ReadLine());
            string convertedora = num.ToString();
            Console.WriteLine("O numero que voce escreveu foi, "+convertedora);
            Console.ReadLine();
            Console.Clear();

        }
    }
    

    internal class Program
    {
            enum opcao {mensagem = 1,sair}
        static void Main()
        {
            bool sair = false;
            while (!sair)
            {
                Console.WriteLine("escolha uma opção abaixo \n 1-mensagem  \n 2-sair");
                opcao opcaoSelecionada = (opcao)int.Parse(Console.ReadLine());
                switch (opcaoSelecionada) 
                {
                    case opcao.sair:
                        sair = true;
                        break;
                        //------------
                    case opcao.mensagem:
                        Mudar.Converter();
                        break;
                        //------------
                    default:
                        Console.WriteLine("ERROR tente novamente");
                        Console.Clear();
                        break;
                }

            }
        }
    }
}
