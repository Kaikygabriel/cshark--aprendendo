using System;

namespace ReservaSalas.Entities
{
    internal class Cliente
    {
        public Cliente() { }

        public Cliente(string nome, string telefone)
        {
            Nome = nome;
            Telefone = telefone;
        }

        public string Id { get;protected set; }= Guid.NewGuid().ToString("N")[..8];
        public string Nome { get; protected set; }
        public string Telefone{ get; protected set; }

        public override string ToString()
        {
            return $"nome : {Nome}\nId:{Id} Telefone:{Telefone}";
        }
        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
        public override bool Equals(object? obj)
        {
            if (!(obj is Cliente))
                throw new Exception("Não eo mesmo tipo que cliente");
            Cliente other = (Cliente)obj;
            return Id.Equals(other.Id);
        }
    }
}
