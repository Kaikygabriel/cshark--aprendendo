using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using TarefasExerciciosChat.Model;

namespace TarefasExerciciosChat.Controler
{
    internal class Funções
    {
        //Iniciando a lista 
        static List<Tarefa> Tarefas= new List<Tarefa>();

        public static void AdicionarTarefa()
        {
            try
            {
                Console.WriteLine("Titulo da tarefa :");
                string titulo = Console.ReadLine().Trim();
                Console.WriteLine("Descrição da tarefa :");
                string descricao = Console.ReadLine().Trim();
                Tarefas.Add(new Tarefa(titulo, descricao));
            }
            catch (Exception ex)
            {
                Console.Clear();
                AdicionarTarefa();
            }
        }
        public static void ConcluirTarefa()
        {
            try
            {
                if(Tarefas.Count > 0)
                {
                    foreach(Tarefa tf in Tarefas)
                    {
                        Console.WriteLine(tf);
                    }
                    Console.WriteLine("Escreva o TItulo da tarefa que deseja concluir : ");
                    string titulo = Console.ReadLine().Trim();
                    bool achou = false;
                    foreach(Tarefa tf in Tarefas)
                    {
                        if (tf.Titulo.Equals(titulo, StringComparison.CurrentCultureIgnoreCase)) 
                        {
                            tf.ConcluirTarefa();
                            Console.WriteLine($"A tarefa {tf.Titulo} foi concluida");
                            achou = true;
                        }
                    }
                    if (!(achou))
                    {
                        Console.WriteLine("Não foi possivel achar a tarefa");
                    }
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("A lista não tem nenhum item adicionado");
                    Console.ReadLine();
                }
            }
            catch(Exception e)
            {
                Console.Clear();
                ConcluirTarefa();
            }
        }
        public static void ListarTarefa()
        {
            if (Tarefas.Count > 0)
            {
                foreach (Tarefa tf in Tarefas)
                {
                    Console.WriteLine(tf);
                }
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("A lista não tem nenhum item adicionado");
                Console.ReadLine();
            }
        }
    }
}


