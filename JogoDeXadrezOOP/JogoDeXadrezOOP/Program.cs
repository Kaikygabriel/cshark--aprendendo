using JogoDaVelhaOOP.Entities;
using JogoDeXadrezOOP.Entities;
using JogoDeXadrezOOP.Entities.Marcador;

namespace JogoDeXadrezOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro t = new Tabuleiro();
            Jogador kaiky = new Jogador("kaiky",XO.X);
            Jogador gabriel = new Jogador("gabriel", XO.O);
            Game game = new Game(t,kaiky,gabriel);
            game.Start();
        }
    }
}
