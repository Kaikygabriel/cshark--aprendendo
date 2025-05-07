using System;
using SistemaDeAgenda.Entity.ExceptionsEntity;

namespace SistemaDeAgenda.Entity
{
    public abstract class Contato
    {
        protected Contato() { }

        protected Contato(string nome, string numero)
        {
            if (VerificarPropiedade(nome, numero))
            {
                throw new DominioException("Nome ou Numero não atendem os requisitos");
            }
            Nome = nome;
            Numero = numero;
        }

        public string Nome { get; private protected set; }
        public string Numero { get; private protected set; }
        public Agenda Contatos { get; set; }
        private protected bool VerificarPropiedade(string nome, string numero)
        {
            if (nome != null && nome.Length > 0 && nome != null && numero.Length > 6)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public virtual void Editar(string nome, string numero)
        {
            if (VerificarPropiedade(nome, numero))
            {
                throw new DominioException("Nome ou Numero não atendem os requisitos");
            }
            Nome = nome;
            Numero = numero;
        }
    }
}
    