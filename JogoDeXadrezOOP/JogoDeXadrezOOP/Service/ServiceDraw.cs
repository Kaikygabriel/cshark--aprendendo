using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JogoDeXadrezOOP.Entities;
using JogoDeXadrezOOP.Entities.Marcador;

namespace JogoDeXadrezOOP.Service
{
    internal sealed class ServiceDraw
    {
        public bool Draw(Tabuleiro tabu)
        {
            bool[] testar = new bool[8];
            int numIndex = 0;
            foreach(var a in tabu.Board)
            {
                foreach(var b in a)
                {
                    if (b.Equals("X") || b.Equals("O"))
                        testar[numIndex++] = true;
                }
                numIndex++;
            }
            if (testar.Length == 8 )
                return true;
            else
                return false;
        }
    }
}
