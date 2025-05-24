using System;
using System.Collections.Generic;
using System.Linq;
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
            Console.WriteLine("Linha e Coluna aonde deseja jogar");
            int numLinha = int.Parse(Console.ReadLine());
            int numColuna = int.Parse(Console.ReadLine());
            jogador.GetMove(tabu, numLinha, numColuna);
        }

    }
}
