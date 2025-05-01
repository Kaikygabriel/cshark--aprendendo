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
                string titulo = Console.ReadLine();
                System.Console.WriteLine("Adicione o ");
            }
            catch (Exception e)
            {

            }
        }
    }
}
