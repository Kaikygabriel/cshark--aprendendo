using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clientes2
{
    [System.Serializable]
    internal class clienteGerenciar
    {
        public string nome;
        public string email;
       public clienteGerenciar(string nome, string email)
        {
            this.nome = nome;
            this.email = email;
        }
    }
}
