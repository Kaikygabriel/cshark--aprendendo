using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace loja
{
    [System.Serializable]
    internal class Estoque
    {
        public string nome;
        public string marca;
        public Estoque(string nome, string marca)
        {
            this.nome = nome;
            this.marca = marca;
        }
       
        public static void Adicionar()
        {
            BinaryFormatter converter = new BinaryFormatter();
            List<Estoque> lista = new List<Estoque>();
            Console.WriteLine("Nome do produto");
            string nome = Console.ReadLine();
            Console.WriteLine("Marca do Produto");
            string marca = Console.ReadLine();
            if (File.Exists("estoque.txt"))
            {
                lista = adicionarAlista();
            }
            FileStream bin = new FileStream("estoque.txt", FileMode.OpenOrCreate);
            lista.Add(new Estoque(nome, marca));    
            converter.Serialize(bin, lista);
            bin.Close();
        }
        static List<Estoque> adicionarAlista()
        {
            BinaryFormatter converter = new BinaryFormatter();
            FileStream bin = new FileStream("estoque.txt", FileMode.Open);
            List<Estoque> lista = (List<Estoque>)converter.Deserialize(bin);
            bin.Close();
            return lista;
        }
        public static void LerLista()
        {
            if (File.Exists("estoque.txt"))
            {
                BinaryFormatter converter = new BinaryFormatter();
                FileStream bin = new FileStream("estoque.txt", FileMode.Open);
                List<Estoque> lista = (List<Estoque>)converter.Deserialize(bin);
                bin.Close();
                if (lista.Count > 0) 
                {
                    foreach (Estoque e in lista)
                    {
                        Console.WriteLine($"O produto :{e.nome}, tem a marca : {e.marca}");
                    }
                }
                else
                {
                    Console.WriteLine("Nada na lista");
                }
            }
            else
            {
                Console.WriteLine("Não foi Possivel achar o arquivo");
            }
        }
    }
}



