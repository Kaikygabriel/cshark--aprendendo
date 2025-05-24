using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JogoDeXadrezOOP.Entities;

namespace JogoDaVelhaOOP.Service
{
    internal class ServiceWinner
    {
        
        public bool Winner(Tabuleiro tabu,Jogador user)
        {
            string[,] board = tabu.Board;
            string marcador = user.Marcador.ToString();
            if (
                board[0, 0] == marcador &&
                board[1, 1] == marcador &&
                board[2, 2] == marcador
                )
                return true;
            if (
                board[0, 2] == marcador &&
                board[1, 1] == marcador &&
                board[2, 0] == marcador
                )
                return true;
            for (int e = 0; e <= 2; e++)
            {
                if (
                 board[e, 2] == marcador &&
                 board[e, 1] == marcador &&
                 board[e, 0] == marcador
                    ) 
                    return true;
            }
            for (int e = 0; e <= 2; e++)
            {
                if (
                 board[e, 2] == marcador &&
                 board[e, 1] == marcador &&
                 board[e, 0] == marcador
                    )
                    return true;
            }
            return false;
        }
    }
}
