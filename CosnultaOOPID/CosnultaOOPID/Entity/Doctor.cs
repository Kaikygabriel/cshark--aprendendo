using System;
using CosnultaOOPID.Entity.Enum;
using System.Text;

namespace CosnultaOOPID.Entity
{
    internal class Doctor
    {
        public Doctor() { }
        public Doctor(string nome, EnumDoctor especialidade)
        {
            Nome = nome;
            Especialidade = especialidade;
        }

        public string Id { get; private set; } = Guid.NewGuid().ToString().Substring(0,8).ToUpper();
        public string Nome { get; private set; } = string.Empty;
        public EnumDoctor Especialidade{ get; private set; }

        public override string ToString()
        {
            return $"NOme doctor - {Nome}\nId - {Id}\nEspecialidade - {Especialidade}";
        }
    }
}
