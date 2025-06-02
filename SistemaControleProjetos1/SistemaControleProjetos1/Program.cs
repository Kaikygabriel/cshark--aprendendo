using SistemaControleProjetos1.Entities;
using SistemaControleProjetos1.Entities.EnumEntities;

namespace SistemaControleProjetos1;

public class Program
{
    static void Main()
    {
        Usuario kaiky = new Usuario("kaiky", "kaiky@gmail.com");
        Tarefa Trabalhar = new Tarefa("Fazer mooke", "Terminar de testar a tarefa", kaiky, Estatus.Pendente);
        Tarefa Trabalhar2 = new Tarefa("Fazer Coco", "Terminar de testar a tarefa", kaiky, Estatus.Pendente);

        Projeto pj = new Projeto("Estudar", kaiky);
        pj.AddTarefa(Trabalhar);
        pj.AddTarefa(Trabalhar2);
        pj.RemoveTarefa(Trabalhar2);
        pj.GetTarefas();
    }
}