using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JogoDaVelhaOOP.Service;
using JogoDeXadrezOOP.Service;

namespace JogoDeXadrezOOP.Entities
{
    internal class Tabuleiro
    {
        public string[,] Board = { { "0", "1", "2"},{"3","4","5"}, { "6", "7", "8" } };
        public ServiceDraw TestarEmpate { get; set; } = new ServiceDraw();
        public ServiceWinner TestarGanhar { get; set; }= new ServiceWinner();
    }
}
