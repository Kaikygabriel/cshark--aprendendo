 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorDeTarefas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mandar();
            ler();
                }
        static void Mandar()
        {
            Console.Clear();
            Tarefas.Carregar();
            Console.WriteLine("Nome da tarefa");
            string nome = Console.ReadLine();
            Console.WriteLine("Esta completa (true), caso não (false)");
            bool completa = bool.Parse(Console.ReadLine());
            Tarefas.tf.Add(new Tarefas(nome, completa));
            Tarefas.Escrever();
        }
        static void ler()
        {
            Console.Clear();
            Tarefas.Carregar();
            List<Tarefas> tfDaqui = Tarefas.tf;
            foreach (Tarefas t in tfDaqui)
            {
                Console.WriteLine($"A tarefa{t.nome}, esta {t.concluida}");
            }

        }
    }
}
