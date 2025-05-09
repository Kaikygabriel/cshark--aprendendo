using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaDeContatos.Entity.EnumEntity;
using SistemaDeContatos.Entity.ExceptionsEntity;

namespace SistemaDeContatos.Entity
{
    internal sealed class Email : Contato
    {
        public Email() { }
        public Email(string email)
        {
            if (email.Length < 0)
            {
                throw new DominioException("Error, Email tem que ter mais de um caracter");
            }
            this.email = email;
            Tipo = TipoContato.Email;
        }
        public string email { get; private set; }
        public override void Exibir()
        {
            Console.WriteLine($"O email é {email}");
        }
    }
}
