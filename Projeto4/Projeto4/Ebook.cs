using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Projeto4
{
    [System.Serializable]
    internal class Ebook: PRoduto
    {
        public string autor;
        private int vendas;
        public Ebook(string autor, int vendas,string nome,float preco):base(nome,preco)
        {
            this.autor = autor;
            this.vendas = vendas;
        }

        public static void adicionar()
        {
            List<Ebook> list = new List<Ebook>();
            BinaryFormatter converter = new BinaryFormatter();
            if (File.Exists("ebook.txt"))
            {
                FileStream bin = new FileStream("ebook.txt", FileMode.Open);
                list = (List<Ebook>)converter.Deserialize(bin);
                bin.Close(); 
            }

            Console.WriteLine("Escreva o nome");
            string nome = Console.ReadLine();
            Console.WriteLine("escreva a preço");
            float preco = float.Parse(Console.ReadLine());
            Console.WriteLine("escreva as vendas");
            int vendas = int.Parse(Console.ReadLine());
            Console.WriteLine("escreva o autor");
            string autor = Console.ReadLine();
            list.Add(new Ebook(autor,vendas,nome,preco));

            FileStream bin1 = new FileStream("ebook.txt",FileMode.OpenOrCreate);
            converter.Serialize(bin1,list);
            bin1.Close();
        }

        public static void exibir()
        {
            
        }

        public static  void saida()
        {
         
        }
    }
}
