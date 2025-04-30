using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hotel.Entity.Entity2;

namespace Hotel.Entity
{
    internal class Hotel
    {
        public Hotel() { }
        public List<Quarto> QuartoList { get; set; } = new List<Quarto>();
        public void AdicionarQuarto()
        {
            Console.WriteLine("Id do quarto"); 
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("valor do quarto");
            double valor = double.Parse(Console.ReadLine());
            Console.WriteLine("Simples Luxo(S/L)");
            string escolha = Console.ReadLine();
            if (escolha.Equals("S", StringComparison.OrdinalIgnoreCase))
            {
                QuartoList.Add(new QuartoSimples(valor,id));
            }
            else
            {
                QuartoList.Add(new QuartoLuxo(valor, id));
            }
        }
    }
}
