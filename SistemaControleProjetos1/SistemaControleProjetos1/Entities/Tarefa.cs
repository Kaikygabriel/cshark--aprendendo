using SistemaControleProjetos1.Entities.EnumEntities;
using SistemaControleProjetos1.Entities.Exceptions;
using System;

namespace SistemaControleProjetos1.Entities;

public class Tarefa
{
    public Tarefa(){}

    public Tarefa(string titulo, string descricao, Usuario usuario, Estatus status)
    {
        Titulo = titulo;
        Descricao = descricao;
        Usuario = usuario;
        Status = status;
    }

    public string Titulo{ get;private set; }
    public string Descricao{ get; private set; }
    public Usuario Usuario { get;private set; }
    public Estatus Status{ get;private set; }

    public override string ToString()
        => $"{Titulo}\nDescrição :{Descricao}\n{Usuario} -- status {Status}";

    public override int GetHashCode()
        => Titulo.GetHashCode();

    public override bool Equals(object? obj)
    {
        if (!(obj is Tarefa))
            throw new DominioException("Obj recebido não é do mesmo tipo que tarefa");
        var other = obj as Tarefa;
        return Titulo.Equals(other.Titulo);
    }

    public void MudarStatus(Estatus status)
        => Status = status;
}