using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Projeto4
{
    [System.Serializable]
    internal class Curso : PRoduto
    {
        public string autor;
        private int vagas;
        public Curso(string autor,string nome,float preco):base(nome,preco)
        {
            this.autor = autor;
            
        }

        public static  void adicionar()
        {
            List<Curso> list = new List<Curso>();
            BinaryFormatter converter = new BinaryFormatter();
            if (File.Exists("curso.txt"))
            {
                FileStream bin1 = new FileStream("curso.txt", FileMode.Open);
                list = (List <Curso>)converter.Deserialize(bin1);
                bin1.Close();
            }
            Console.WriteLine("Nome do autor");
            string autor = Console.ReadLine();
            Console.WriteLine("Nome do curso");
            string nome = Console.ReadLine();
            Console.WriteLine("Preço do curso");
            float preco = float.Parse(Console.ReadLine());
            FileStream bin = new FileStream("curso.txt", FileMode.OpenOrCreate);
            converter.Serialize(bin,list);
            bin.Close();
        }

        public static void exibir()
        {
           
            if (File.Exists("curso.txt"))
            {
                BinaryFormatter converter = new BinaryFormatter();
                FileStream bin1 = new FileStream("curso.txt", FileMode.Open);
                
                try
                {
                    List<Curso> list = (List<Curso>)converter.Deserialize(bin1);
                    
                    if (list.Count > 0)
                    {
                        foreach (Curso l in list)
                        {
                            Console.WriteLine($"O curso {l.nome} tem o preço de R${l.preco} eo autor {l.autor}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("ERROR");
                    }
                }
                catch(Exception e)
                {
                    Console.WriteLine("ERROR");
                }
                bin1.Close();
            }
            else
            {
                Console.WriteLine("ERROR");
            }
        }

        public void saida()
        {
           
        }
    }
}

                