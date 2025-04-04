using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jogoDaVelha
{
    internal class Program
    {
        static char[,] base1 = {
                {'1','2','3'} ,
                {'4','5','6' },
                {'7','8','9' }
            };
         static  bool ganho = true;
        static  bool empate = true;
        static void Main()
        {
            
            while (ganho && empate)
            {
                Console.Clear();
                Console.WriteLine("Bem Vindo ao Jogo da velha");
                Exibir();
              
                jogarBolinha();
                jogarX();
                GanharBolinha();
                GanharX();
                GanharDiagonalBolinha();
                GanharDiagonalX();
                GanharCimaBolinha();
                GanharCimaX();
                VerificarEmpate();
            }
        }
        static void Exibir()
        {
            
            Console.WriteLine($" {base1[0, 0]} | {base1[0, 1]} | {base1[0, 2]}");
            Console.WriteLine("---+---+---");
            Console.WriteLine($" {base1[1, 0]} | {base1[1, 1]} | {base1[1, 2]}");
            Console.WriteLine("---+---+---");

            Console.WriteLine($" {base1[2, 0]} | {base1[2, 1]} | {base1[2, 2]}");

        }
        static void jogarBolinha()
        {
            
                Console.Write("Bolinha jogar : ");
                char bolinha = char.Parse(Console.ReadLine());
                for(int b = 0; b <= 2; b ++)
                {
                    for(int a = 0; a <= 2; a ++)
                    {
                        if (bolinha.Equals(base1[b, a]))
                        {
                            base1[b, a] = 'O';
                        }
                    }
                }
                
        
        }
        static void jogarX()
        {
            Console.Write("x jogar : ");
            char x = char.Parse(Console.ReadLine());
            for (int b = 0; b <= 2; b++)
            {
                for (int a = 0; a <= 2; a++)
                {
                    if (x.Equals(base1[b, a]))
                    {
                        base1[b, a] = 'X';
                    }
                }
            }
          
        }
        static void GanharBolinha()
        {
            for (int e = 0; e <= 2; e++)
            {
                int num = e;
                List<bool> inicial = new List<bool>() { true, true, true };
                List<bool> testar = new List<bool>() { };

                char bolinha = 'O';
              
                    for (int a = 0; a <= 2; a++)
                    {
                        if (bolinha.Equals(base1[num, a]))
                        {
                            testar.Add(true);
                        }
                        else
                        {
                            testar.Add(false);
                        }
                    }
                if (inicial.SequenceEqual(testar))
                {
                    Console.WriteLine("O Bolinha venceu");
                    Exibir();
                    Console.ReadLine();
                    ganho = false;
                    break;
                }

            }
        }
        static void GanharX()
        {
            for (int e = 0; e <= 2; e++)
            {
                int num = e;
                List<bool> inicial = new List<bool>() { true, true, true };
                List<bool> testar = new List<bool>() { };

                char x = 'X';

                for (int a = 0; a <= 2; a++)
                {
                    if (x.Equals(base1[num, a]))
                    {
                        testar.Add(true);
                    }
                    else
                    {
                        testar.Add(false);
                    }
                }
                if (inicial.SequenceEqual(testar))
                {
                    Console.WriteLine("O X venceu");
                    Exibir();
                    Console.ReadLine();
                    ganho = false;

                    break;
                }

            }
        }
        static void GanharDiagonalBolinha()
        {

            for (int e = 0; e <= 2; e++)
            {
                int num = e;
                List<bool> inicial = new List<bool>() { true, true, true };
                List<bool> testar = new List<bool>() { };
                List<bool> testar1= new List<bool>() { };
                int add = 0;
                int add2 = 0;
                char bolinha = 'O';

                for (int a = 2; a >= 0; a--)
                {
                    int i = 1;
                    if( i == 1)
                    {
                        if( add <= 2)
                        {
                            if (bolinha.Equals(base1[add, a]))
                            {
                                testar.Add(true);
                            }
                            else
                            {
                                testar.Add(false);
                            }
                            i = 2;
                            add = add + 1;
                        }
                    
                    }
                 
                }
                for (int a = 0; a <= 2; a++)
                {
                    int i = 1;
                    if (i == 1)
                    {
                        if(add2 <= 2)
                        {
                            if (bolinha.Equals(base1[add2, a]))
                            {
                                testar1.Add(true);
                            }
                            else
                            {
                                testar1.Add(false);
                            }
                            i = 2;
                            add2 += 1;
                        }
                    
                    }
                }
                if (inicial.SequenceEqual(testar))
                {
                    Console.WriteLine("O Bolinha venceu");
                    Console.ReadLine();
                    ganho = false;
                    break;
                }
                if (inicial.SequenceEqual(testar1))
                {
                    Console.WriteLine("O Bolinha venceu");
                    Exibir();
                    Console.ReadLine();
                    ganho = false;
                    break;
                }
            }
        }
        static void GanharDiagonalX()
        {

            for (int e = 0; e <= 2; e++)
            {
                int num = e;
                List<bool> inicial = new List<bool>() { true, true, true };
                List<bool> testar = new List<bool>() { };
                List<bool> testar1 = new List<bool>() { };

                int add = 0;
                int add2 = 0;
                char x = 'X';

                for (int a = 2; a >= 0; a--)
                {
                    int i = 1;
                    if (i == 1)
                    {
                        if (add <= 2)
                        {
                            if (x.Equals(base1[add, a]))
                            {
                                testar.Add(true);
                            }
                            else
                            {
                                testar.Add(false);
                            }
                            i = 2;
                            add = add + 1;
                        }

                    }

                }
                for (int a = 0; a <= 2; a++)
                {
                    int i = 1;
                    if (i == 1)
                    {
                        if (add2 <= 2)
                        {
                            if (x.Equals(base1[add2, a]))
                            {
                                testar1.Add(true);
                            }
                            else
                            {
                                testar1.Add(false);
                            }
                            i = 2;
                            add2 += 1;
                        }

                    }
                }
                if (inicial.SequenceEqual(testar))
                {
                    Console.WriteLine("O X venceu");
                    Exibir();
                    Console.ReadLine();
                    ganho = false;
                    break;
                }
                if (inicial.SequenceEqual(testar1))
                {
                    Console.WriteLine("O X venceu");
                    Exibir();
                    Console.ReadLine();
                    ganho = false;
                    break;
                }

            }
        }
        static void GanharCimaBolinha()
        {
            for (int e = 0; e <= 2; e++)
            {
                int num = e;
                List<bool> inicial = new List<bool>() { true, true, true };
                List<bool> testar = new List<bool>() { };

                char bolinha = 'O';

                for (int a = 0; a <= 2; a++)
                {
                    if (bolinha.Equals(base1[a, num]))
                    {
                        testar.Add(true);
                    }
                    else
                    {
                        testar.Add(false);
                    }
                }
                if (inicial.SequenceEqual(testar))
                {
                    Console.WriteLine("O bolinha venceu");
                    Exibir();
                    Console.ReadLine();
                    ganho = false;

                    break;
                }
            }
        }
        static void GanharCimaX()
        {
            for (int e = 0; e <= 2; e++)
            {
                int num = e;
                List<bool> inicial = new List<bool>() { true, true, true };
                List<bool> testar = new List<bool>() { };

                char x = 'X';

                for (int a = 0; a <= 2; a++)
                {
                    if (x.Equals(base1[a, num]))
                    {
                        testar.Add(true);
                    }
                    else
                    {
                        testar.Add(false);
                    }
                }
                if (inicial.SequenceEqual(testar))
                {
                    Console.WriteLine("O X venceu");
                    Exibir();
                    Console.ReadLine();
                    ganho = false;

                    break;
                }
            }
        }
        static void VerificarEmpate()
        {
            bool preenchido = true;
            foreach (var item in base1)
            {
                if (item == '1' || item == '2' || item == '3' || item == '4' || item == '5' || item == '6' || item == '7' || item == '8' || item == '9')
                {
                    preenchido = false;
                    break;
                }
            }

            if (preenchido)
            {
                Console.WriteLine("Empate!");
                empate = false;
            }
        }
    }
}
