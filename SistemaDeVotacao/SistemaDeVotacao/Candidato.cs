using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeVotacao
{
    internal class Candidato
    {
        public string Nome;
        public int Id;
        private int votos;
          public Candidato(string nome, int id)
        {
            Nome = nome;
            Id= id;
        }
        public override string ToString()
        {
            return $"O Candidato {Nome} ganhou!!";
        }
        public static void AdicionarCandidato()
        {
            Console.WriteLine("Nome");
            string nome = Console.ReadLine();
            Console.WriteLine("id");
            int id = int.Parse(Console.ReadLine());
            Program.listCandidato.Add(new Candidato(nome, id)); 
        }
        public void addvoto()
        {
            votos += 1;
        }
    }
}
