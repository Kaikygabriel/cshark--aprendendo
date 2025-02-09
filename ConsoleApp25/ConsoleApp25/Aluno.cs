using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp25
{
    [System.Serializable]
    internal class Aluno : Usuario
    {
        
        public Aluno(string nome,string email,string senha)
        {
            if (nome.Length > 0 && senha != null && senha.Length > 0 && email.Length > 0 && email != null && nome != null) 
            {
                this.nome = nome;
                this.email = email;
                this.senha = senha;
            } 
        }

        public static void adicinar()
        {
            List<Aluno> alunos = new List<Aluno>();
            BinaryFormatter converter = new BinaryFormatter();
            if (File.Exists("aluno.txt"))
            {
                FileStream bin1 = new FileStream("aluno.txt", FileMode.Open);
                alunos = (List<Aluno>)converter.Deserialize(bin1);
                bin1.Close();
            }
            FileStream bin = new FileStream("aluno.txt", FileMode.OpenOrCreate);
            Console.WriteLine("NOme do aluno");
            string nome = Console.ReadLine();
            Console.WriteLine("email do aluno");
            string email = Console.ReadLine();
            Console.WriteLine("senha do aluno");
            string senha = Console.ReadLine();
           
            alunos.Add(new Aluno(nome, email, senha));
            converter.Serialize(bin, alunos);
            Console.WriteLine("aluno adicionado");
            bin.Close();
        }
        public static void verAluno()
        {
            if (File.Exists("aluno.txt"))
            {
                BinaryFormatter converter = new BinaryFormatter();
                FileStream bin1 = new FileStream("aluno.txt", FileMode.Open);
                List<Aluno> alunos = (List<Aluno>)converter.Deserialize(bin1);
                Console.WriteLine("digite o nome do aluno");
                string nome = Console.ReadLine();
                Aluno encontrar = alunos.Find(a => a.nome.Equals(nome, StringComparison.OrdinalIgnoreCase));
                if (encontrar != null)
                {
                    Console.WriteLine($"aluno encontrado, {encontrar.nome}, tem o email {encontrar.email} ea senha {encontrar.senha}");
                }
                else
                {
                    Console.WriteLine("aluno não encontrado \n veja os alunos abaixos logados");
                    foreach (Aluno l in alunos)
                    {
                        Console.WriteLine($"aluno : {l.nome} email: {l.email}");
                    }

                }
            }
            else
            {
                Console.WriteLine("ERRO");
            }
        }
        public static void remove()
        {
            if (File.Exists("aluno.txt"))
            {
                BinaryFormatter converter = new BinaryFormatter();
                FileStream bin1 = new FileStream("aluno.txt", FileMode.Open);
                List<Aluno> alunos = (List<Aluno>)converter.Deserialize(bin1);
                foreach (Aluno l in alunos)
                {
                    Console.WriteLine($"aluno : {l.nome} email: {l.email}");
                }
                bin1.Close();
                Console.WriteLine("digite o nome do aluno que deseja remover");
                string nome = Console.ReadLine();
                Aluno encontrar = alunos.Find(a => a.nome.Equals(nome, StringComparison.OrdinalIgnoreCase));
                int index = alunos.IndexOf(encontrar);
                if (index != -1)
                {
                    alunos.RemoveAt(index);
                    FileStream bin2 = new FileStream("aluno.txt", FileMode.Create);
                    converter.Serialize(bin2, alunos);
                    bin2.Close();
                }
                else
                {
                    Console.WriteLine("nao foi possível remover");
                }
            }
            else
            {
                Console.WriteLine("erro");
            }
        }
    }
}
