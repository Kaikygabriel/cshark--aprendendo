using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Turmas.Entidade
{
    internal class Aluno
    {
        public Aluno() { }
        public Aluno(string nome, int idade,float nota)
        {
            Nome = nome;
            Idade = idade;
            Nota = nota;
        }

        public string Nome{ get; private set; }
        public int Idade {  get; private set; }
        public float Nota{ get; private set; }
        public override string ToString()
        {
            return $"O Aluno {Nome} tem a Idade {Idade} ea nota {Nota.ToString("F1",CultureInfo.InvariantCulture)}";
        }
    }
}
