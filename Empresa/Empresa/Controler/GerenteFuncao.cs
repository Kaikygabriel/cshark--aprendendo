using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Empresa.Entidade;

namespace Empresa.Controler
{
    internal class GerenteFuncao
    {
        static List<Gerente> gerentes = new List<Gerente>();
        public static void AdicionarGerente()
        {
            try
            {
                Console.WriteLine("Nome do gerente");
                string nome = Console.ReadLine();
                Console.WriteLine("Salario do gerente");
                float salario = float.Parse(Console.ReadLine());
                Console.WriteLine("Id do gerente");
                int id = int.Parse(Console.ReadLine());
                gerentes.Add(new Gerente(nome,salario ,id));
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR tente novamente");
                Console.ReadLine();
                Console.Clear();
                AdicionarGerente();
            }
        }
        public static void PagarGerente()
        {
            try
            {
                if(gerentes.Count > 0)
                {
                    foreach (Gerente g in gerentes)
                    {
                        Console.WriteLine($"O gerente {g.Nome} tem o id {g.Id} o salario esta {(g.Pago ? "pago" : "Não pago")}");
                    }
                    Console.WriteLine("Informe o id do gerente que deseja pagar");
                    int id = int.Parse(Console.ReadLine());
                    foreach(Gerente g2 in gerentes)
                    {
                        if(g2.Id == id)
                        {
                            if (!(g2.Pago))
                            {
                                Console.WriteLine("Informe o salario do gerente");
                                float salario = float.Parse(Console.ReadLine());
                                Console.WriteLine("Informe a quantidade de vendas do gerente");
                                int quantidade  = int.Parse(Console.ReadLine());
                                g2.PagarGerente(salario,quantidade);
                                Console.WriteLine("O gerente ja foi pago");
                            }
                            else
                            {
                                Console.WriteLine($"O gerente {g2.Nome} ja esta pago");
                            }
                        }
                    }
                }
                Console.ReadLine();
            }
            catch(Exception ex)
            {
                Console.WriteLine("ERROR");
                Console.ReadLine(); ;
            }
        }
    }
}
    
