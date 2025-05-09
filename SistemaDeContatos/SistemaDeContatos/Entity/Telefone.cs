using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaDeContatos.Entity.EnumEntity;
using SistemaDeContatos.Entity.ExceptionsEntity;

namespace SistemaDeContatos.Entity
{
    internal class Telefone : Contato
    {

        public Telefone() { }
        public Telefone(string telefone)
        {
            if (telefone.Length < 0)
            {
                throw new DominioException("Error, Email tem que ter mais de um caracter");
            }
            this.telefone = telefone;
            Tipo = TipoContato.Telefone;
        }
        public string telefone { get; private set; }
        public override void Exibir()
        {
            Console.WriteLine($"O email é {telefone}");
        }
    }
}
