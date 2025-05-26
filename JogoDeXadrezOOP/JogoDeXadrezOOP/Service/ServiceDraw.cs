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
            List<bool> testar = new List<bool>();

            for (int i = 0; i <= 2; i++)
            {
                for (int a = 0; a <= 2; a++)
                {
                    for (int e = 0; e <= 8; e++)
                    {
                        if (tabu.Board[i, a].Equals(e.ToString()))
                            testar.Add(true);
                    }
                }

            }
            if (testar.Count == 0 )
                return true;
            else
                return false;
        }
    }
}
