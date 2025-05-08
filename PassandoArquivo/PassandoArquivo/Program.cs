using System;
using System.IO;
using PassandoArquivo.Entity;

namespace PassandoArquivo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw = null;
            StreamReader sr = null;
            string path = @"C:\Users\kaiky\Downloads\Loja\item.csv";
            try
            {
                sr = new StreamReader(path);
                List<string> teste = new List<string>();
                while (!sr.EndOfStream)
                {
                    teste.Add(sr.ReadLine());
                }

                List<Item> items = new List<Item>();
                int valor = 0;
                while(valor <= teste.Count -1 )
                {
                    string[] teste2 = new string[teste.Count];
                    teste2 = teste[valor].Split(',');
                    double price = double.Parse(teste2[1]);
                    int quantidade = int.Parse(teste2[2]);
                    string nome = teste2[0].ToString();
                    items.Add(new Item(nome, price,quantidade));
                    valor++;
                }
               
                Directory.CreateDirectory(@"C:\Users\kaiky\Downloads\Loja\out");
                sw = File.AppendText(@"C:\Users\kaiky\Downloads\Loja\out\item2.csv");
                foreach(Item i in items)
                {
                    sw.Write(i.Nome + ",");
                    sw.WriteLine(i.ValorTotal());
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                sr.Close();
                sw.Close();
            }
        }
    }
}
