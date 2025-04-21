using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimuladorDeInvestimento.Entidade;

namespace SimuladorDeInvestimento.Controler
{
    internal class Funcao
    {
        static RendaFixa Investimento = new RendaFixa();
        public static void AdicionarInvestimento()
        {
            try
            {
                Console.WriteLine("Insira o valor inicial do investimetno");
                float valor = float.Parse(Console.ReadLine());
                Investimento = new RendaFixa(valor);
            }
            catch (Exception ex)
            {
                Console.Clear();
                AdicionarInvestimento();
            }
        }
        public static void CalcularRenda()
        {
            try
            {
                if(Investimento != null)
                {
                    Console.WriteLine("Insira quantos anos deseja calcular");
                    int anos = int.Parse(Console.ReadLine());
                    Investimento.CalcularAno(anos);
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("ERROR");
                }
            }
            catch (Exception ex)
            {
                Console.Clear();
                CalcularRenda();
            }
        }
    }
}


