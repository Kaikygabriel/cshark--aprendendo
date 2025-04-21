using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClienteProduto.Entidade.Enum;

namespace ClienteProduto.Entidade
{
    internal class Cliente
    {
        public string Nome;
        public string Email;
        
        public Cliente() { }

        public Cliente(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }
        public Pedido pedido = new Pedido();
        public void AdicionarPedido(Status p)
        {
            pedido = new Pedido(p);
        }
        public override string ToString()
        {
            return $"CLiente {Nome} \n Email {Email}";
        }
    }
}
