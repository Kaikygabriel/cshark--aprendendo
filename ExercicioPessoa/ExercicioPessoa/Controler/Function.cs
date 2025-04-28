using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExercicioPessoa.Entity;

namespace ExercicioPessoa.Controler
{
    internal class Function
    {
        static List<Pessoa> Pessoas = new List<Pessoa>();
        public static void Adicionar()
        {
            Console.WriteLine("Numero de pessoas");
            int numPessoas = int.Parse(Console.ReadLine().Trim());
            for (int i = 1; i <= numPessoas; i++)
            {
                Console.WriteLine("Juridica ou Fisica (J/F)");
                string escolha = Console.ReadLine();
                Console.WriteLine("Nome");
                string nome = Console.ReadLine();
                Console.WriteLine("Renda");
                double renda = double.Parse(Console.ReadLine());
                if (escolha.Equals("F", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Gasto com saude");
                    double saude = double.Parse(Console.ReadLine());
                    Pessoas.Add(new PessoaFisica(nome,renda,saude));
                }
                else
                {
                    Console.WriteLine("Numero de  funcionarios");
                    int numFuncionario = int.Parse(Console.ReadLine());
                    Pessoas.Add(new PessoaJuridica(numFuncionario,nome,renda));
                }

            }
            foreach (Pessoa p in Pessoas)
            {
                Console.WriteLine(p.ImpostoTotal().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
        public static void ImpostoTotal()
        {
            double soma = 0;
            foreach(Pessoa p in Pessoas)
            {
                soma += p.ImpostoTotal();
            }
            Console.WriteLine($"Imposto total é de R${soma.ToString("F2",CultureInfo.InvariantCulture)}");
        }
    }
}
