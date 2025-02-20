using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace logarSistema
{

    [System.Serializable]
    internal class Usuario
    {
        public int senha;
        public string name;

        public Usuario(int senha, string name)
        {
            if(senha >= 1 && name.Length > 1 && name !=null )
            this.senha = senha;
            this.name = name;
        }
        public static void logar(string nome,int senha)
        {
            
        }
        public static void logar(int senha,string email,string nome)
        {
            List<Google> usuariog = new List<Google>();
            BinaryFormatter converter = new BinaryFormatter();
            if (File.Exists("usuario-g.txt"))
            {
                FileStream bin1 = new FileStream("usuario-g.txt", FileMode.Open);
                usuariog = (List<Google>)converter.Deserialize(bin1);
                bin1.Close();
            }
            FileStream bin = new FileStream("usuario-g.txt", FileMode.OpenOrCreate);
            usuariog.Add(new Google(nome,senha,email));
            converter.Serialize(bin, usuariog);
            bin.Close();
            Console.WriteLine("Conta criada");
        }
        public static void verGoogle()
        {
            if(File.Exists("usuario-g.txt"))
            {
                Console.WriteLine("insira o nome da sua conta ");
                List<Google> usuariog = new List<Google>();
                BinaryFormatter converter = new BinaryFormatter();
                FileStream bin = new FileStream("usuario-g.txt", FileMode.Open);
                string nome = Console.ReadLine();
                usuariog = (List<Google>)converter.Deserialize(bin);
                int index = -1;
                bin.Close();
               for(int i = 0;i < usuariog.Count; i++)
                {
                    if (usuariog[i].name == nome)
                    {
                        index = i;
                    }
                }
               if(index != -1)
                {
                    Console.WriteLine("ola " + usuariog[index].name +" "+ usuariog[index].email);
                    
                }
                else
                {
                    Console.WriteLine("conta não encontrada tente novamnete");
                    Console.ReadLine();
                    Console.Clear();
                    verGoogle();
                }
                
            }
            else
            {
                Console.WriteLine("erro404");
            }
        }
    }
}
