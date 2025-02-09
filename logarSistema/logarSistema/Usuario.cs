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
                Console.WriteLine("as contas criadas são");
                List<Google> usuariog = new List<Google>();
                BinaryFormatter converter = new BinaryFormatter();
                FileStream bin = new FileStream("usuario-g.txt", FileMode.Open);
                usuariog = (List<Google>)converter.Deserialize(bin);
                bin.Close();
                foreach(Google u in usuariog)
                {
                    Console.WriteLine($"o usuario: {u.name}, tem o email: {u.email} ea senha: {u.senha}");
                }
            }
            else
            {
                Console.WriteLine("erro404");
            }
        }
    }
}
