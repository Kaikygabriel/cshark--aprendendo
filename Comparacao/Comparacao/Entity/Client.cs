using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace Comparacao.Entity
{
    internal sealed class Client 
    {
        public string Nome { get; internal set; }
        public string Email{ get; internal set; }

        
        public override bool Equals(object? obj)
        {
            if (!(obj is Client))
                throw new ArgumentException("Error tipo não igual a cliente");

            Client cliente = (Client)obj;
            return Email.Equals(cliente.Email);
        }

        public override int GetHashCode()
        {
            return Email.GetHashCode();
        }
    }
}

