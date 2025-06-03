using GerenciadorTarefasOOP.Entities.EnumEntities;
using GerenciadorTarefasOOP.Entities;

namespace GerenciadorTarefasOOP;

public class Program
{
    static void Main()
    {
        Tarefa produto = new Tarefa( "Fazer site","fazer um site para alguem",DateTime.Now.AddDays(20));
        Tarefa produto2 = new Tarefa( "Fazer computador","fazer um computador para alguem",DateTime.Now.AddDays(10));
        produto2.Concluir();
        
        Projeto estudo = new Projeto();
        estudo.Tasks.Add(produto);
        estudo.Tasks.Add(produto2);
        estudo.GetTask();
    }
}