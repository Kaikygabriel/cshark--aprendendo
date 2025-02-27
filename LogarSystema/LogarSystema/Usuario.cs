using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace LogarSystema
{
    [System.Serializable]
    internal class Usuario
    {
        public string nome;
        public int senha;
        public Usuario(string nome, int senha)
        {
            this.nome = nome;
            this.senha = senha;
        }
        public static void LerAdd()
        {
            if (File.Exists("usuario.txt"))
            {
                BinaryFormatter converter = new BinaryFormatter();
                FileStream bin = new FileStream("usuario.txt", FileMode.Open);
                List<Google> usuarios = (List<Google>)converter.Deserialize(bin);
                bin.Close();
                if (usuarios != null && usuarios.Count > 0)
                {
                    foreach (Google a in usuarios)
                    {
                        Console.WriteLine($"bem vindo usuario {a.nome} , seu email é {a.email}");
                    }
                }
                else
                {
                    Console.WriteLine("NADA VAI LOGAR");
                }
            }
            else
            {
                Console.WriteLine("NADA VAI LOGAR");
            }
        }
        
    }
    
}
