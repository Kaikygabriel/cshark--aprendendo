using GerenciadorTarefasOOP.Entities.EnumEntities;

namespace GerenciadorTarefasOOP.Entities;

public class Projeto
{
    public List<Tarefa> Tasks { get; set; } = new List<Tarefa>();
    public string Descricao { get;private set; }

    public void GetTask()
    {
        
        Console.WriteLine("tasks concluidas");
        var taskConcluida = Tasks.Where(x => x.Status == EStatusTask.concluida).ToList();
        foreach (var t in taskConcluida)
        {
            Console.WriteLine(t);
        }
        
        Console.WriteLine("tasks pendentes");
        var taskPendente = Tasks.Where(x => x.Status == EStatusTask.pendente).ToList();
        foreach (var t in taskPendente)
        {
            Console.WriteLine(t);
        }
    }
}
