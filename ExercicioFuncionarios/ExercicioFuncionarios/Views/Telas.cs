using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExercicioFuncionarios.Controler;
using ExercicioFuncionarios.Entity;

namespace ExercicioFuncionarios.Views
{
    internal class Telas
    {
        public static void TelaIncial()
        {
            Console.WriteLine("Quantos funcioario deseja acresentar");
            int numFuncionario = int.Parse(Console.ReadLine());
            for (int i = 1; i <= numFuncionario; i++)
            {
                Console.WriteLine("Funcionario e primario (s/n)");
                string teste = Console.ReadLine().Trim();
                Console.WriteLine($"#{i}");
                if (teste.Equals("s", StringComparison.OrdinalIgnoreCase))
                {
                    Function.AdicionarFuncionario();
                }
                else
                {
                    Function.AdicionarFuncionarioTerceiro();
                }
            }
            Function.ListarFuncionario();
        }
    }
}
