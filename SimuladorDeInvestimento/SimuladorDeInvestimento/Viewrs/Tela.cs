using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimuladorDeInvestimento.Controler;

namespace SimuladorDeInvestimento.Viewrs
{
    internal class Tela
    {
        public static void TelaInicial()
        {
            try
            {
                bool sair = true;
                while (sair)
                {
                    Console.WriteLine("1- Criar investimetno \n 2- calcular investimento\n 3 - sair");
                    int escolha = int.Parse(Console.ReadLine());
                    switch (escolha)
                    {
                        case 1:
                            Funcao.AdicionarInvestimento();
                            break;
                        case 2:
                            Funcao.CalcularRenda();
                            break;
                        case 3:
                            sair = false;
                            break;
                        default:
                            break;
                    }
                    Console.Clear();
                }
            }
            catch(Exception e)
            {
                Console.Clear();
                TelaInicial();
            }
        }
    }
}
