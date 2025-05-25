using System;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using PlataformaCursosAvaliaçõesCertificados.Entities.Exceptions;

namespace PlataformaCursosAvaliaçõesCertificados.Entities
{
    internal sealed class Aluno
    {
        public Aluno() { }

        public Aluno(string nome,Avaliacao notafinal)
        {
            NotaFinal = notafinal;
            Nome = nome;
        }

        public string Nome { get; private set; }
        public string Id { get; private set; }= Guid.NewGuid().ToString("N").ToUpper()[..8];
        public SortedSet<Curso> Cursos { get; set; } = new SortedSet<Curso>();
        public Avaliacao NotaFinal { get;private set; }
        public override string ToString()
        {
            return $"{Nome} -- {Id}";
        }
        public override int GetHashCode()
        {
            return Nome.GetHashCode();
        }
        public override bool Equals(object? obj)
        {
            if (!(obj is Aluno))
                throw new DominioException("O tipo recebido não é do tipo aluno.");
            Aluno other = (Aluno)obj;
            return Nome.Equals(other.Nome);
        }
    }
}
