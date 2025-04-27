using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GerenciadorTarefaPOO.Entity.EnumPasta;


namespace GerenciadorTarefaPOO.Entity
{
    internal class Usuario
    {
        public Usuario() { }

        public Usuario(string nome)
        {
            Nome = nome;
        }

        public string Nome{ get; set; }
        public List<Tarefa> Tarefas { get; set; } = new List<Tarefa>();
        public void AdicionarTarefa()
        {
            try
            {
                Console.WriteLine("Tarefa prioriataria (s/n)");
                string escolha = Console.ReadLine().Trim();
                if ("s".Equals(escolha,StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Nome da tarefa:");
                    string nome = Console.ReadLine().Trim();
                    Console.WriteLine("Descrição da tarefa");
                    string descricao = Console.ReadLine().Trim();
                    Console.WriteLine($"Status {Status.Concluida} / {Status.Pendente}");
                    Status status = Enum.Parse<Status>(Console.ReadLine().Trim());
                    Tarefas.Add(new Tarefa(descricao,nome, status));
                }
                else
                {
                    Console.WriteLine("Nome da tarefa:");
                    string nome = Console.ReadLine().Trim();
                    Console.WriteLine("Descrição da tarefa");
                    string descricao = Console.ReadLine().Trim();
                    Console.WriteLine($"Status {Status.Concluida} / {Status.Pendente}");
                    Status status = Enum.Parse<Status>(Console.ReadLine().Trim());
                    Console.WriteLine("Data de validade");
                    DateTime validade = DateTime.Parse(Console.ReadLine());
                    Tarefas.Add(new TarefaPrioritaria(validade,nome,descricao,status));
                }                
            }
            catch (Exception e)
            {
                Console.Clear();
                AdicionarTarefa();
            }
        }
        public void ListarTarefa()
        {
            if(Tarefas.Count > 0)
            {
                foreach(Tarefa t in Tarefas)
                {
                    t.Exibir();
                }
            }
            else
            {
                Console.WriteLine("ERROR");
            }
        }
    }
}

