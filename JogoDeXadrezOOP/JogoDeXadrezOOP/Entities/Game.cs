using System;
using JogoDaVelhaOOP.Control;
using JogoDeXadrezOOP.Entities;
using JogoDeXadrezOOP.Views;

namespace JogoDaVelhaOOP.Entities
{
    internal class Game
    {
        public Game() { }

        public Game(Tabuleiro tabuleiro, Jogador play1, Jogador play2)
        {
            this.tabuleiro = tabuleiro;
            this.play1 = play1;
            this.play2 = play2;
        }

        public Tabuleiro tabuleiro { get; set; } = new Tabuleiro();
        public Jogador play1 { get; set; } = new Jogador();
        public Jogador play2 { get; set; } = new Jogador();
        public void Start()
        {
            bool teste = false;
            while (!teste)
            {
                GetBoard.GetTabuleiro(tabuleiro);
                FuctionsGame.StartJogador(play1, tabuleiro);
                
                if (tabuleiro.TestarGanhar.Winner(tabuleiro, play1) == true)
                {
                    Console.WriteLine($"O player {play1.Nome} ganhou");
                    teste = true;
                    break;
                    Console.ReadLine();
                }
                FuctionsGame.StartJogador(play2, tabuleiro);
                if (tabuleiro.TestarGanhar.Winner(tabuleiro, play2) == true)
                {
                    Console.WriteLine($"O player {play2.Nome} ganhou");
                    teste = true;
                    break;
                    Console.ReadLine();
                }
              
                Console.Clear();
            }
            
        }
    }
}
