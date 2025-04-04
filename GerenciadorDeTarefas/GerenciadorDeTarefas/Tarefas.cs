using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorDeTarefas
{
    [System.Serializable]
    internal class Tarefas
    {
        public static List<Tarefas> tf = new List<Tarefas>();
        public string nome;
        public bool concluida;
        public Tarefas(string nome, bool concluida)
        {
            this.nome = nome;
            this.concluida = concluida;
        }
       public static void Carregar()
        {
            if (File.Exists("tarefas.txt"))
            {
                try
                {
                    BinaryFormatter converter = new BinaryFormatter();
                    FileStream bin = new FileStream("tarefas.txt", FileMode.Open);
                    if (bin.Length > 0)
                    {
                        tf = (List<Tarefas>)converter.Deserialize(bin);
                    }
                    bin.Close();
                } 
                catch(Exception e)
                {
                    Console.WriteLine("ERROR");
                }
            }
        }
        public static void Escrever()
        {
            try
            {
                if(tf.Count > 0)
                {
                    if(File.Exists("tarefas.txt"))
                    {
                        Carregar();
                    }
                    BinaryFormatter converter = new BinaryFormatter();
                    FileStream bin = new FileStream("tarefas", FileMode.OpenOrCreate);
                    converter.Serialize(bin, tf);
                    bin.Close();
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
        }
    }
}

