using System;
using System.Runtime.Serialization;

namespace ConsoleApp8
{
    public class calculo
    {
        public static void Calcular()
        {
            Console.WriteLine("Escolha dois valores para fazer a soma");
            Console.WriteLine("VAlor 1");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("VAlor 2");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("resultado");
            int soma = num1 + num2;
            Console.WriteLine(soma);
            Console.ReadLine();
            Console.Clear();
            Program.Main();

        }
    }
    //--------------------------------------------CALCULAR
    public class Menu
    {
        
        public static string AparecerMenu()
        {
            return"1-adicionar\n 2-editar\n3-excluir";

;        }
        public static void Abrir()
        {
           int index = int.Parse(Console.ReadLine());
        Program.menu abrir = ((Program.menu)index);
            switch (abrir)
            {
                case Program.menu.adicionar:
                    Console.WriteLine("Voce adicionou, parabens");
                    break;
                case Program.menu.editar:
                    Console.WriteLine("Voce editou, parabens");
                    break;
                case Program.menu.excluir:
                    Console.WriteLine("Voce excluiu, parabens");
                    break;
                default:
                    Console.WriteLine("ERROR, opção não encontrada");
                    break;
            }

            Console.ReadLine();
            Console.Clear();
            Program.Main();
        }
         
    }
    //----------------------------------------------------------------------------------------MENU
    internal class Program
    {
        public enum menu { adicionar = 1, editar,excluir}
        
       
     public   static void Main()
        {
            Console.WriteLine("Quer fazer a função 1-calculo ou a função 2-menu");
            int valorescolhido = int.Parse(Console.ReadLine());
            switch (valorescolhido)
            {
                case 1:
                    Console.Clear();
                    calculo.Calcular();
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine(Menu.AparecerMenu());
                    Menu.Abrir();
                    break;
                default:
                    Console.WriteLine("valor não encontrado, insira novamente");
                    Console.Clear();
                    Program.Main();
                        break;
            }


        }

    }
}
