using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace loja
{
    enum opLoja { maça = 1, banana }
    [System.Serializable]
    internal class loja
    {
        public string nome;
        public float preco;
        public loja(string nome, float preco)
        {
            this.nome = nome;
            this.preco = preco;
        }
        public static void Comprar()
        {
            BinaryFormatter converter = new BinaryFormatter();
            List<loja> Carrinho = new List<loja>();
            if (File.Exists("carrinho.txt"))
            {
                FileStream bin = new FileStream("carrinho.txt", FileMode.Open);
                Carrinho = (List<loja>)converter.Deserialize(bin);
                bin.Close();
            }
            Console.WriteLine("1-Maça \n 2-Banana");
            opLoja indexEscolha = (opLoja)int.Parse(Console.ReadLine());
            switch (indexEscolha)
            {
                case opLoja.maça:
                    Carrinho.Add(new Fruta("maça",2f));
                    break;
                case opLoja.banana:
                    Carrinho.Add(new Fruta("Banana",3f));
                    break;
                default:
                    Console.Write("NADA");
                    break;
            }
            if(Carrinho.Count > 0)
            {
                FileStream bin = new FileStream("carrinho.txt", FileMode.OpenOrCreate);
                converter.Serialize(bin, Carrinho);
                bin.Close();
            }
            Console.ReadLine();
        }
        public static void Ver()
        {
            if (File.Exists("carrinho.txt"))
            {
                BinaryFormatter converter = new BinaryFormatter();
                List<loja> Carrinho = new List<loja>();
                FileStream bin = new FileStream("carrinho.txt", FileMode.Open);
                Carrinho = (List<loja>)converter.Deserialize(bin);
                bin.Close();
                if (Carrinho.Count > 0)
                {
                    foreach (loja loja in Carrinho)
                    {
                        Console.WriteLine($"Os item são {loja.nome} que tem o preço de R${loja.preco}");
                    }
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Nada no carrinho");
                }
            }
            else
            {
                Console.WriteLine("Carrinho não encontrado");
            }
            
        }
        public static void Total()
        {
            if (File.Exists("carrinho.txt"))
            {
                BinaryFormatter converter = new BinaryFormatter();
                List<loja> Carrinho = new List<loja>();
                FileStream bin = new FileStream("carrinho.txt", FileMode.Open);
                Carrinho = (List<loja>)converter.Deserialize(bin);
                bin.Close();
                if (Carrinho.Count > 0)
                {
                    float total = 0;
                    foreach (loja loja in Carrinho)
                    {
                        if(total != loja.preco)
                        {
                            total = loja.preco;
                            if(total != loja.preco)
                            {
                                total = total+loja.preco;
                            }
                        }
                    }
                    Console.WriteLine($"o total é {total}");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Nada no carrinho");
                }
            }
            else
            {
                Console.WriteLine("Carrinho não encontrado");
            }
        }
    }
}
