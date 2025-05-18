using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosnultaOOPID.Entity
{
    internal class Paciente
    {
        public Paciente() { }

        public Paciente(string nome, string descricao)
        {
            Nome = nome;
            Descricao = descricao;
        }

        public string Nome { get; private set; } = string.Empty;
        public string Descricao { get; set; }= string.Empty;
        public override string ToString()
        {
            return $"Nome - {Nome}\nDescrição - {Descricao}"; 
        }
    }
}
