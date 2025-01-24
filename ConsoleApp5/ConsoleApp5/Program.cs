using System;

namespace ConsoleApp5
{
    class Program
    {
        static string Pnome = "kaiky";
        //variavel precisa ser static
        enum opcao { inicio = 1, editar }

        static void Main()
        {
            ExibirMsg();
            // uma variavel com escopo global, tudo do codigo e capaz de acessar a variavel
            //a classe Program eo escopo global(tudo que esta dentro dele pode acessa-la (variavel) )
            //quando eu crio uma variavel dentro de uma função ela fica presa aquela função(so aquela função pode acessa-la)
            List<int> valores = new List<int>() { 1, 2, 3 };
            valores.Add(0);
            valores.Sort();
            Console.WriteLine(valores[1]);
            Console.WriteLine("Digite uma das opcões abaixo");
            Console.WriteLine("inicio \n editar");
            int index = int.Parse(Console.ReadLine());
            opcao opcaoselecionada = ((opcao)index);
            switch (opcaoselecionada)
            {
                case opcao.inicio:
                    Console.WriteLine("VOce inicioou");
                    break;
                case opcao.editar:
                    Console.WriteLine("VOce editou");
                    break;
                default:
                    Console.WriteLine("nao foi possivel encontrar");
                    break;
            }
        }
        static void ExibirMsg()
        {
            Console.WriteLine(Pnome);
        }

    }
}