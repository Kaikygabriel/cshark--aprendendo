using System.Runtime.InteropServices.JavaScript;
using GerenciadorTarefasOOP.Entities.EnumEntities;

namespace GerenciadorTarefasOOP.Entities;

public class Tarefa
{
    public Tarefa(){}

    public Tarefa(string title, string description, DateTime data)
    {
        if (data < DateTime.Now)
            throw new Exception("ERROR, date is bigger the date now");
        Title = title;
        Description = description;
        Data = data;
    }
   
    public string Id { get;private set; } = Guid.NewGuid().ToString()[..8];
    public string Title { get;private set; }
    public string Description { get;private set; }
    public DateTime Data{ get;private set; }
    public EStatusTask Status { get; private set; } = EStatusTask.pendente;

    public override string ToString()
        => $"{Title}\n{Description}\nDate {Data.ToString("dd/MM/yyyy")} status {Status}";

    public override int GetHashCode()
        => Title.GetHashCode();

    public override bool Equals(object? obj)
    {
        if (!(obj is Tarefa))
            throw new Exception("Error, obj not is taks");
        Tarefa other = obj as Tarefa;
        return Title.Equals(other.Title);
    }

    public void Concluir()
        => Status = EStatusTask.concluida;
}