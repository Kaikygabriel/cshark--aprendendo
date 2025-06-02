using SistemaControleProjetos1.Entities.Exceptions;

namespace SistemaControleProjetos1.Entities;

public class Projeto
{
    public Projeto(){}

    public Projeto(string nome, Usuario responsavel)
    {
        Nome = nome;
        Responsavel = responsavel;
    }

    public string Nome { get; private set; }
    public Usuario Responsavel { get;private set; }
    public List<Tarefa> Tarefas { get;private set; } = new List<Tarefa>();

    public void AddTarefa(Tarefa  tarefa)
    {
        if(Tarefas.Exists(x => x.Equals(tarefa)))
            throw new DominioException("Error tarefa ja existe");
        Tarefas.Add(tarefa);
    }
    public void RemoveTarefa(Tarefa  tarefa)
    {
        if(!Tarefas.Exists(x => x.Equals(tarefa)))
            throw new DominioException("Error tarefa não existe");
        Tarefas.Remove(tarefa);
    }
    public void GetTarefas()
    {
        Console.WriteLine($"Projeto {Nome} Responsavel {Responsavel}");
        Console.WriteLine("Tareafas  : ");
        foreach (var t in Tarefas)
            Console.WriteLine(t);
    }
}