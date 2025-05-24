using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JogoDeXadrezOOP.Entities.Marcador;

namespace JogoDeXadrezOOP.Entities
{
    internal class Jogador
    {
        public Jogador() { }

        public Jogador(string nome, XO marcador)
        {
            Nome = nome;
            Marcador = marcador;
        }

        public string Nome { get; private set; }
        public XO Marcador { get;  private set; }
        public void GetMove(Tabuleiro tabuleiro,int numColuna,int numLinha)
        {
            if (tabuleiro.Board[numLinha, numColuna] == null)
                throw new Exception("Não existe a posição no tabuleiro");
                tabuleiro.Board[numLinha, numColuna] = Marcador.ToString();
        }
    }
}
