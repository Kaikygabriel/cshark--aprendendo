using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leilao.Entity
{
    internal sealed class Cliente
    {
        Cliente() { }

        public Cliente(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public List<Item> Items { get; set; } = new List<Item>();
        public void AdicionarItems()
        {
            try
            {
                System.Console.WriteLine("Adicione o nome do produto/serviço");
                string titulo = Console.ReadLine().Trim();
                System.Console.WriteLine("Adicione descrição ao produto");
                string descricao = Console.ReadLine().Trim();
                System.Console.WriteLine("Valor do produto");
                double valor = double.Parse(Console.ReadLine().Trim());
                System.Console.WriteLine("Produto ou Serviço (P/S)");
                string escolha = Console.ReadLine().Trim();
                if (escolha.Equals("P", StringComparison.OrdinalIgnoreCase))
                {
                    System.Console.WriteLine("Peso do produto");
                    double peso = double.Parse(Console.ReadLine().Trim());
                    Items.Add(new Produto(peso, titulo, descricao, valor));
                }
                else
                {
                    System.Console.WriteLine("Horas de serviço");
                    TimeSpan horas = TimeSpan.Parse(Console.ReadLine().Trim());
                    Items.Add(new Servico(horas, titulo, descricao, valor));
                }
            }
            catch (Exception e)
            {
                System.Console.WriteLine("ERROR " + e.Message);
                Console.ReadLine();
            }
            
        }
    }
}
