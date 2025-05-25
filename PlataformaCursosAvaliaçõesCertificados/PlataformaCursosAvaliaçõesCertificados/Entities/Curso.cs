using System;
using System.Collections.Generic;
using System.Text;
using PlataformaCursosAvaliaçõesCertificados.Entities.Exceptions;

namespace PlataformaCursosAvaliaçõesCertificados.Entities
{
    internal class Curso
    {
        public Curso() { }
        public Curso(string titulo)
        {
            Titulo = titulo;
        }

        public string Titulo{ get; private set; }
        public List<int> Avaliacao { get;private set; }=new List<int>();
        public SortedSet<Aluno>Alunos { get; private set; }= new SortedSet<Aluno>();

        public void AdicionarAluno(Aluno aluno)
        {
            Alunos.Add(aluno);
            aluno.Cursos.Add(this);
        }
        public void AdicionarAvaliacao(int Nota)
        {
            if (Nota <= 10 && Nota >= 0)
                Avaliacao.Add(Nota);
            else
                throw new DominioException("Nota e maior ou menor que 10 ou 0");
        }
        public double GetAvaliacao()
        {
            int value = 0;
            foreach (int i in Avaliacao)
                value += i;
            return value/Avaliacao.Count;
        }
    }
}
