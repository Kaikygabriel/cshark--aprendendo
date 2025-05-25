using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;
using JogoDeXadrezOOP.Entities;
using JogoDeXadrezOOP.Entities.Marcador;

namespace JogoDaVelhaOOP.Control
{
    internal static  class FuctionsGame
    {
        public static void StartJogador(Jogador jogador,Tabuleiro tabu)
        {
            Console.WriteLine("Numero aonde deseja jogar");
            string numJogar = Console.ReadLine();
            jogador.GetMove(tabu, numJogar);
        }
    }
}
