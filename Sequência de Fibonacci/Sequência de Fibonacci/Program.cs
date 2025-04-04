using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sequência_de_Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fibonacci(7);

        }
        static void Fibonacci(int num)
        {
            //int outro = 0;
            //int total = 0;
            //int qualquer = 0;
            //List<int> list = new List<int>();
            //List<int> list2 = new List<int>();
            //List<int> list3 = new List<int>();
            //List<int> list4 = new List<int>();
            //for (int i = 0; i <= num; i++)
            //{
            //    if(i <= 1)
            //    {
            //        list.Add(i);
            //        Console.Write($"{i} ,  ");
            //    }
            //    else if(i <= 2)
            //    {
            //        total = list[i - 2] + list[i -1];
            //        Console.Write($"{total} , ");
            //        list2.Insert(0,total);

            //    }
            //    else
            //    {
            //        if (qualquer == 0)
            //        {

            //             qualquer = total + 1;
            //            outro = qualquer;
            //            Console.Write($"{qualquer} kk ");
            //            list3.Insert(0, qualquer);
            //            list4.Insert(0, outro);
            //        }
            //        else
            //        {
            //            qualquer = list3[0] + total;


            //            list3.Insert(0, qualquer);
            //            Console.Write($"{qualquer} k");


            //        }

            //    }

            //}
            List<int> fibonacciSequence = new List<int>();

            // Condições iniciais
            int a = 0, b = 1;

            // Gerar a sequência até o número especificado
            for (int i = 0; i < num; i++)
            {
               
                Console.Write($"{a} ");    // Exibe o número na tela

                // Atualiza os valores para os próximos números
                int next = a + b;
                a = b;
                b = next;
            }

            Console.WriteLine(); // Quebra de linha após imprimir todos os números
        }
    }
}

