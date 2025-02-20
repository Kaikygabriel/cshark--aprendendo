using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace loja
{
    [System.Serializable]
    internal class estoque : PRoduto
    {
        public int quantia;
        public estoque(int quantia,string nome,string marca,float preco):base(nome, marca, preco) 
        {
            this.quantia = quantia;
        }

       public static void adiconar()
        {
            BinaryFormatter bf = new BinaryFormatter();
            List<estoque> estoques = new List<estoque>();
            Console.WriteLine("Nome do produto");
            string nome = Console.ReadLine();
            Console.WriteLine("Marca do produto");
            string marca = Console.ReadLine();
            Console.WriteLine("preço do produto");
            float preco = float.Parse(Console.ReadLine());
            Console.WriteLine("Quantia de produto");
            int quantia = int.Parse(Console.ReadLine());
            if (File.Exists("estoque.txt"))
            {       
                FileStream bin1 = new FileStream("estoque.txt", FileMode.Open);
                estoques = (List<estoque>)bf.Deserialize(bin1);
                bin1.Close();
            }
            estoques.Add(new estoque(quantia, nome, marca, preco));
            FileStream bin = new FileStream("estoque.txt", FileMode.OpenOrCreate);
            bf.Serialize(bin, estoques);
            bin.Close();
        }
        public static void Ver()
        {
            BinaryFormatter bf = new BinaryFormatter();
            List<estoque> estoques = new List<estoque>();
            FileStream bin = new FileStream("estoque.txt", FileMode.Open);
            estoques = (List<estoque>)bf.Deserialize(bin);
            foreach (estoque es in estoques)
            {
                Console.WriteLine($"O produto {es.nome}, tem a marca {es.marca} eo preço de R${es.preco}");
            }
        }
    }
}
