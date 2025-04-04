using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace NotasDeAlunos
{

    internal class Program
    {
        static List<Aluno> alunos = new List<Aluno>();
        enum op { add = 1,ver,sair}
        static void Main()
        {
            bool sair = true;
            while (sair)
            {
                Console.WriteLine("Gerenciador de Alunos \n 1- Adicionar alunos \n 2- Ver alunos \n 3 - sair");
                try
                {
                    op sele = (op)int.Parse(Console.ReadLine());
                    switch (sele)
                    {
                        case op.add:
                            Console.Clear();

                            AdicionarAluno();
                            break;

                        case op.ver:
                            Console.Clear();

                            Ver();
                            break;

                        case op.sair:
                            sair = false;
                            break;
                        default:
                            Console.WriteLine("ERROR");
                            break;
                    }
                    Console.Clear();
                }
                catch (Exception e)
                {
                    Console.WriteLine("ERROR");

                }
            }
        }
        static void Carregar()
        {
            try
            {

                if (File.Exists("aluno.txt"))
                {
                    BinaryFormatter converter = new BinaryFormatter();
                    FileStream bin = new FileStream("aluno.txt", FileMode.Open);
                    alunos = (List<Aluno>)converter.Deserialize(bin);
                    bin.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("[ERROR] não foi possivel acessar o arquivo");
            }
        }
        static void Enviar()
        {
              try
              {
                  if (File.Exists("aluno.txt"))
                  {
                    Carregar();
                  }
                  FileStream bin = new FileStream("aluno.txt", FileMode.Create);
                  BinaryFormatter converter = new BinaryFormatter();
                  converter.Serialize(bin, alunos);
                  bin.Close();
              }
              catch (Exception e)
              { 
                  Console.WriteLine("[ERROR] não foi possivel colocar o arquivo");
              }
        }
        static void AdicionarAluno()
        {
            BinaryFormatter converter = new BinaryFormatter();
         
            if (File.Exists("aluno.txt"))
            {
                Carregar();
            }
            Console.Write("Nome : ");
            string nome = Console.ReadLine();
            Console.Write("Nota-1 : ");
            int nota1 = int.Parse(Console.ReadLine());
            Console.Write("Nota-2 : ");
            int nota2 = int.Parse(Console.ReadLine());
            Console.Write("Nota-3 : ");
            int nota3 = int.Parse(Console.ReadLine());
            alunos.Add(new Aluno(nome, nota1, nota2, nota3));
            FileStream bin = new FileStream("aluno.txt", FileMode.OpenOrCreate);
            converter.Serialize(bin,alunos);
            bin.Close();     
            Enviar();
        }
        static void Ver()
        {
            if (File.Exists("aluno.txt"))
            {

                Carregar();

                foreach (Aluno a in alunos)
                {
                    a.exibir();
                }
                Console.ReadLine();
            }
        }
    }
}


