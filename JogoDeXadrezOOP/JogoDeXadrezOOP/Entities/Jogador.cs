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
        public XO Marcador { get; private set; }
        public void GetMove(Tabuleiro tabuleiro, string casa)
        {
            for (int i = 0; i <= 2; i++)
            {
                for (int e = 0; e <= 2; e++)
                {
                    if (tabuleiro.Board[i, e].Equals(casa, StringComparison.InvariantCultureIgnoreCase))
                    {
                        tabuleiro.Board[i, e] = Marcador.ToString();
                        return;
                    }
                }
            }
            throw new Exception("Não existe a posição no tabuleiro");
        }
    }
}
