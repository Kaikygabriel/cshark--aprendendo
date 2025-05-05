using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supemercado.EntityPagamento;

namespace Supemercado.EntityCliente
{
    internal class Cliente
    {
        public Cliente() { }
        public string Nome { get; private set; }
        public Pagamento Pagar { get; private set; }
        public List<Items> items { get; set; } = new List<Items>();

        //funções cliente pagamento
        public void AdicionarPagamento()
        {
            Console.WriteLine("Pagamento cartão / Pagamento dinheiro (C/D)");
            string escolha = Console.ReadLine();
            if (escolha.Equals("C", StringComparison.InvariantCultureIgnoreCase))
            {
                Pagar = new PagamentoCartao(); 
            }
            else
            {
                Pagar = new PagamentoCache();
            }
        }
    }
}
