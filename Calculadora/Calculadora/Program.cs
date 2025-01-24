using System;


namespace Calculadora
{
    public class contas
    {
        public static void mais()
        {
            Console.Clear();
            Console.WriteLine("Valor 1");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Valor 2");
            int num1 = int.Parse(Console.ReadLine());
            int soma = num1 + num;
            Console.WriteLine($"o resultado da soma é {soma}");
            Console.ReadLine();
            Console.Clear();
            Program.Main();
        }
        public static void menos()
        {
            Console.Clear();
            Console.WriteLine("Valor 1");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Valor 2");
            int num1 = int.Parse(Console.ReadLine());
            int menos = num1 - num;
            Console.WriteLine($"o resultado da subtração é {menos}");
            Console.ReadLine();
            Console.Clear();
            Program.Main();
        }
        public static void divisao()
        {
            Console.Clear();
            Console.WriteLine("Valor 1");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Valor 2");
            int num1 = int.Parse(Console.ReadLine());
            float disicao = (float)num1 / num; //colocando so em um o cast, os dois ja viram elemento float
            Console.WriteLine($"o resultado da disisão é {disicao}");
            Console.ReadLine();
            Console.Clear();
            Program.Main();
        }
        public static void vezes()
        {
            Console.Clear();
            Console.WriteLine("Valor 1");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Valor 2");
            int num1 = int.Parse(Console.ReadLine());
            int vezes = num1 * num;
            Console.WriteLine($"o resultado da vezes é {vezes}");
            Console.ReadLine();
            Console.Clear();
            Program.Main();
        }
        public static void potencia()
        {
            Console.Clear();
            Console.WriteLine("Valor 1");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o expoente");
            int num1 = int.Parse(Console.ReadLine());
            int pot = (int)Math.Pow(num,num1);
            Console.WriteLine($"o resultado da potencia é {pot}");
            Console.ReadLine();
            Console.Clear();
            Program.Main();
        }
    }


    internal class Program
    {
        enum opcao{mais = 1,menos,divisão,vezes,potencia,sair}
        public static void Main()
        {

            bool sairescolhar = false;

            while (!sairescolhar)// enquanto o usuario não(!) escolher sair
            {

                Console.WriteLine("CALCULADORA \n escolha uma das opcões abaixo \n 1-mais \n 2-menos \n 3-divisão \n 4-vezes \n 5- potencia \n 6-sair");
                opcao sele = (opcao)int.Parse(Console.ReadLine());

                switch (sele)
                {
                    case opcao.mais:
                        contas.mais();
                        break;
                    case opcao.menos:
                        contas.menos();
                        break;
                    case opcao.divisão:
                        contas.divisao();
                        break;
                    case opcao.vezes:
                        contas.vezes();
                         break;
                    case opcao.potencia:
                        contas.potencia();
                        break;
                    case opcao.sair:
                         sairescolhar = true;
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("Opção não encontrada, tente novamente");
                        Console.ReadLine();
                        Console.Clear();
                        Main();
                        break;
                }
            }

        }
    }
}
