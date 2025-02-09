using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp27
{
    [System.Serializable]
    internal class Professor : Usuario
    {
        public string materia;
        public Professor(string materia, string nome, string email, string senha):base( nome,  email, senha)
        {
            this.materia = materia;
            exibir();
        }
       public void ir()
        {
            if (File.Exists("texto.txt"))
            {

            }
            else
            {
                FileStream a = new FileStream("texto.txt", FileMode.OpenOrCreate);
                BinaryFormatter bin = new BinaryFormatter();
                bin.Serialize(a, this.nome);
                a.Close();
            }
        }
       public static void sla()
        {
            Console.WriteLine("OI KAIKY");
        }
    }
}

