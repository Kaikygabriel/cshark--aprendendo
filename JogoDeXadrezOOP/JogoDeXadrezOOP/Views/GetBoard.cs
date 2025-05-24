using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JogoDeXadrezOOP.Entities;

namespace JogoDeXadrezOOP.Views
{
    internal static class GetBoard
    {
        public static void GetTabuleiro(Tabuleiro tabu)
        {
            string[,] base1 = tabu.Board;

            Console.WriteLine($" {base1[0, 0]} | {base1[0, 1]} | {base1[0, 2]}");
            Console.WriteLine("---+---+---");
            Console.WriteLine($" {base1[1, 0]} | {base1[1, 1]} | {base1[1, 2]}");
            Console.WriteLine("---+---+---");

            Console.WriteLine($" {base1[2, 0]} | {base1[2, 1]} | {base1[2, 2]}");

        }
    }
}
