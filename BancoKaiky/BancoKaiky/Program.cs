using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace BancoKaiky
{
    internal class Program
    {
        static List<Usuario> usuarios = new List<Usuario>();
        enum op {sacar = 1,adicionar,sair}
        static void Main()
        {
         
            
                if (File.Exists("banco.txt"))
                {
                    BinaryFormatter converter = new BinaryFormatter();
                    FileStream bin = new FileStream("banco.txt", FileMode.Open);
                    usuarios = (List<Usuario>)converter.Deserialize(bin);
                    bin.Close();
                    if (usuarios.Count > 0)
                    {
                        bool sair = true;
                        while (sair)
                        {
                            Console.WriteLine("Bem Vindo "+ usuarios[0].Nome  + " ! \n 1 -sacar dinheiro   \n 2-Adiconar mais ao saldo \n 3 - sair");
                            op sele = (op)int.Parse(Console.ReadLine());
                            switch (sele)
                            {
                                case op.sacar:
                                    Console.WriteLine("Diigte o valor para sacar");
                                    float valor = float.Parse(Console.ReadLine());
                                    usuarios[0].Sacar(valor);
                                    Console.WriteLine(usuarios[0]);
                                    Console.ReadLine();
                                    break;
                                case op.adicionar:
                                    Console.WriteLine("Diigte o valor para adicionar");
                                    float Valoradd = float.Parse(Console.ReadLine());
                                    usuarios[0].AdicionarCarteira(Valoradd);
                                    Console.WriteLine(usuarios[0]);
                                    Console.ReadLine();
                                    break;
                                case op.sair:
                                    sair = false;
                                    Console.ReadLine();
                                    break;
                                default:
                                    Console.WriteLine("Nada escolhido");
                              
                                    break;
                            }
                        Console.Clear();
                        }
                    }
                    else
                    {
                        adicionar();
                    }
                }
                else
                {
                    adicionar();
                }
            } 
           
      
        static void adicionar()
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream add = new FileStream("banco.txt", FileMode.OpenOrCreate);
            Console.WriteLine("Voce não tem uma conta criada \n digite seu nome ");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite o quanto voce quer adicionar ao seu saldo no banco");
            float saldo = float.Parse(Console.ReadLine());
            usuarios.Add(new Usuario(nome,saldo));
            bf.Serialize(add, usuarios);
            add.Close();
            Main();
        }
    }
}
