using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeVotacao
{
    internal class Eleitor
    {
        public string nome;
        public int cpf;
        public int voto { get; private set; }
        public Eleitor(string nome, int cpf)
        {
            this.nome = nome;
            this.cpf = cpf;
            voto = 0;
        }
        public Eleitor() { }
        
        public static void Votar()
        {
            Console.WriteLine("Digite o seu cpf");
            foreach (Eleitor ele in Program.listEleitor)
            {
                Console.WriteLine($"O {ele.nome} tem o cpf {ele.cpf}");
            }
            try
            {
                bool achou = false;
                Console.Write("Cpf : ");
                int cpf = int.Parse(Console.ReadLine());
                Eleitor al = new Eleitor();
                foreach (Eleitor ele in Program.listEleitor)
                {
                    if (ele.cpf == cpf)
                    {
                        achou = true;
                        al = ele;
                    }   
                }

                if (!achou)
                {
                    Console.WriteLine("Não achei");
                    Console.ReadLine();
                    Console.Clear(); 
                    Votar();
                }
                if(al.voto == 1)
                {
                    foreach (Candidato a in Program.listCandidato)
                    {
                        Console.WriteLine($"O Candidato {a.Nome} tem o id {a.Id}");
                    }
                    Console.WriteLine("Insita o id do candidato que deseja votar");
                    int id = int.Parse(Console.ReadLine());
                    bool achouCandidato = false;
                    foreach (Candidato ele in Program.listCandidato)
                    {
                        if (ele.Id == id)
                        {
                            achouCandidato = true;
                            ele.addvoto();
                            Console.WriteLine($"O candidato {ele.Nome} recebeu um voto");

                        }
                    }
                    al.voto = 1;
                    if (!achou)
                    {
                        Console.WriteLine("Não achei");
                        Console.ReadLine();
                        Console.Clear();
                        Votar();
                    }
                   
                }
                Console.ReadLine();
            }
            catch(Exception e)
            {
                Console.WriteLine("ERROR");
                Console.ReadLine();
                Console.Clear();
                Votar();
            }
        }
        public static void AdicionarEleitor()
        {
            Console.WriteLine("Nome");
            string nome = Console.ReadLine();
            Console.WriteLine("Cpf");
            int cpf = int.Parse(Console.ReadLine());
            Program.listEleitor.Add(new Eleitor(nome, cpf));
        }
    }
}
