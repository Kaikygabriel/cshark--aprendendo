using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Clientes2
{
    internal class Program
    {
        static void Main()
        {
            BinaryFormatter converter = new BinaryFormatter();
            List<clienteGerenciar> clientes = new List<clienteGerenciar>();
            if (File.Exists("clientes.txt"))
            {
                FileStream bin2 = new FileStream("clientes.txt", FileMode.Open);
                clientes = (List<clienteGerenciar>)converter.Deserialize(bin2);
                bin2.Close();
            }
            Console.WriteLine("escreva o nome do cliente que deseja adicionar");
            string nomec = Console.ReadLine();
            Console.WriteLine("escreva o email do cliente que deseja adicionar");
            string emailc = Console.ReadLine();
            clientes.Add(new clienteGerenciar(nomec,emailc));
            FileStream bin = new FileStream("clientes.txt", FileMode.OpenOrCreate);
            converter.Serialize(bin, clientes);
            bin.Close();
            if (File.Exists("clientes.txt"))
            {
                FileStream bin2 = new FileStream("clientes.txt", FileMode.Open);
                List<clienteGerenciar> clientessalvo = (List<clienteGerenciar>)converter.Deserialize(bin2);
                foreach(clienteGerenciar a in clientessalvo)
                {
                    Console.WriteLine($"cliente {a.nome}, tem o email {a.email}");

                }
                bin2.Close();
            }

        }
    }
}
