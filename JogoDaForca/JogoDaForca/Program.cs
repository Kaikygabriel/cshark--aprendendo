using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace JogoDaForca
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            Random al = new Random();
            List<string> list = new List<string>() {"ruby","csharp","phyton","java"};
            int NumAleatorio = al.Next(0,list.Count - 1);
            Forca(list[NumAleatorio]);
        }
        static void Forca(string a)
        {
            List<char> tamanho = new List<char>();
            List<char> list = new List<char>();
            List<char> list2 = new List<char>();
            List<char> list3 = new List<char>();
            for (int i = 0; i <= a.Length -1 ; i++)
            {
                
                list.Add(a[i]);
                tamanho.Add('_');
            }
           
            int tentativa = 0;
            while (!list.SequenceEqual(tamanho))
            {
                if (tentativa <= a.Length + 4)
                {


                    if (tentativa == 0)
                    {
                        Console.WriteLine("Bem Vindo ao jogo \n Escolha uma letra");
                        foreach (char t in tamanho)
                        {
                            Console.Write($" {t}");
                        }
                        Console.WriteLine();
                        char letra = char.Parse(Console.ReadLine());
                        tentativa += 1;
                        bool testar = false;

                        for (int i = 0; i <= list.Count - 1; i++)
                        {
                            if (list[i].Equals(letra))
                            {

                                tamanho.RemoveAt(i);
                                tamanho.Insert(list.IndexOf(list[i]), letra);
                                testar = true;
                            }
                        }
                        if (testar)
                        {
                            //faça nada

                        }
                        else
                        {
                            list3.Add(letra);
                        }
                    }
                    else
                    {
                        if (list3.Count > 0)
                        {
                            Console.WriteLine("Letras erradas");
                            foreach (char l in list3)
                            {
                                Console.Write($", {l}");
                            }
                        }
                        Console.WriteLine();
                        Console.WriteLine($"Voce ja teve {tentativa} \n Escolha outra letra ");
                        foreach (char t in tamanho)
                        {
                            Console.Write($" {t}");
                        }
                        Console.WriteLine();
                        char letra = char.Parse(Console.ReadLine());
                        tentativa += 1;
                        bool testar = false;

                        for (int i = 0; i <= list.Count - 1; i++)
                        {
                            if (list[i].Equals(letra))
                            {

                                tamanho.RemoveAt(i);
                                tamanho.Insert(list.IndexOf(list[i]), letra);
                                testar = true;
                            }
                        }
                        if (testar)
                        {
                            //faça nada

                        }
                        else
                        {
                            list3.Add(letra);
                        }
                        Console.Clear();
                    }
                }
                else
                {
                    Console.WriteLine("Limites de tentativas atinjido , tentativas = " + tentativa);
                    break;
                }
            }
            if(tentativa <= a.Length + 4)
            {
                Console.WriteLine("PARABENS ACERTOU A PALAVRA ERA " + a);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Limites de tentativas atinjido , tentativas = " + tentativa);
            }
        }
    }
}

                   
