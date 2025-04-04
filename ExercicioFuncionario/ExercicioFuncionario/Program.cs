using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioFuncionario
{
    internal class Program
    {
        static List<Funcionario> list = new List<Funcionario>();
        static void Main()
        {
            Console.WriteLine("Indique quantos funcionarios deseja acressentar");
            int QuantidadeFuncionario = int.Parse(Console.ReadLine());
           

            for(int i = 1; i < QuantidadeFuncionario +1; i++)
            {
                Console.WriteLine("Adicionando pela " + i + " vez");
                Console.Write("Nome : ");
                string nome = Console.ReadLine();
                Console.Write("id : ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("salario : R$");
                float salario = float.Parse(Console.ReadLine());
                list.Add(new Funcionario(nome,salario,id));
                Console.WriteLine("");
            }
            Adicionar();
        }
        static void Adicionar()
        {
            Console.WriteLine("Indique o id do funcionario que deseja aumentar o salario");
            int id = int.Parse(Console.ReadLine());
            bool achou = false;
            foreach (Funcionario funcionario in list)
            {
                if (funcionario.Id ==id)
                {
                    achou = true;
                    Console.WriteLine("Digite a porcentagem que deseja aumentar");
                    int por = int.Parse(Console.ReadLine());
                    funcionario.adiconar(por);
                    Console.WriteLine(funcionario);
                }
            }
            if (!achou)
            {
                Console.WriteLine("Não foi possivel achar");
            }
           
        }
    }
}
