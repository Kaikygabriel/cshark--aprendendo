using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaDeContatos.Entity.EnumEntity;

namespace SistemaDeContatos.Entity
{
    internal abstract class Contato
    {
        public Contato() { }
       
        protected TipoContato Tipo { get; private protected set; }
        public TipoContato GetTipo()
        {
            return Tipo;
        }
        public abstract void Exibir();
    }
}
