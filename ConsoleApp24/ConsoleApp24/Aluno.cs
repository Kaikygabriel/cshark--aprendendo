using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ConsoleApp24
{
    internal class Aluno
    {
        private string nome;
        private int chamada;
        public Aluno(string nome, int chamada)
        {
            if ((nome.Length > 0 && nome != null) && chamada > 0)
            {
                this.chamada = chamada;
                this.nome = nome;
            }
            else
            {
                Console.WriteLine("eror");
            }
        }
        enum op { ver =1 , add }
        public static void sala1()
        {
            Console.WriteLine("Escolha uma opçao\n 1-ver \n 2-adicionar");
            op sele = (op)int.Parse(Console.ReadLine());
            switch (sele) 
            {
                case op.add:
                    List<Aluno> alunos = new List<Aluno>();
                    Console.WriteLine("NOME ALUNO");
                    string nome = Console.ReadLine();
                    Console.WriteLine("CHAMada");
                    int chamada = int.Parse(Console.ReadLine());
                    alunos.Add(new Aluno(nome, chamada));
                    StreamWriter escrever = File.AppendText("sala-1.txt");
                    foreach(Aluno aluno in alunos)
                    {
                        escrever.WriteLine(aluno.nome);
                       
                    }
                    escrever.Close();
                    break;
                case op.ver:
                    if (File.Exists("sala-1.txt"))
                    {
                        List<string> aluno = new List<string>();
                        StreamReader ler = new StreamReader("sala-1.txt");
                        string linha = "";
                        while(linha != null)
                        {
                            linha = ler.ReadLine();
                            if(linha != null)
                            {
                                aluno.Add(linha);
                            }
                        }
                        ler.Close();
                        foreach(string l in aluno)
                        {
                            Console.WriteLine($"O aluno {l}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("erro");
                    }
                    break;
            }
        }
    }
}

            
