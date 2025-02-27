using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace LogarSystema
{
    [System.Serializable]
    internal class Google:Usuario
    {
        public string email;

        public Google(string email,string nome,int senha):base(nome, senha) 
        {
            this.email = email;
        }
        public static void adiconarGoogle()
        {
            List<Google> usuario = new List<Google>();
            BinaryFormatter converter = new BinaryFormatter();
            Console.WriteLine("Escreva o email");
            string email = Console.ReadLine();
            Console.WriteLine("Escreva o nome de usuario");
            string nome = Console.ReadLine();
            bool teste = false;
            while (!teste)
            {
                Console.WriteLine("escreva a senha (Somente numeros)");
                int senha = int.Parse(Console.ReadLine());
                Console.WriteLine("escreva novamente, para confirmar, caso não funcione reescreva a senha");
                int senha2 = int.Parse(Console.ReadLine());
                if (senha == senha2)
                {
                    usuario.Add(new Google(email, nome, senha));
                    teste = true;
                }
                else
                {
                    Console.WriteLine("Senha incorreta");
                    Console.Clear();
                }

            }
            FileStream bin = new FileStream("usuario.txt", FileMode.OpenOrCreate);
            converter.Serialize(bin, usuario);
            bin.Close();
         

        }
    }
}
