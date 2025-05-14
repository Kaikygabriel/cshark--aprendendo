using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ProcessadorDePagamento.Entity
{
    internal  class Conta
    {
        public Conta() { }

        public  Conta(double valor)
        {
            Valor = valor;
            //id aleatorio
            Id = Guid.NewGuid().ToString().Substring(0,8).ToUpper();
        }

        public double Valor { get;private set; }
        public string Id { get;private set; }
        public List<HistoricoCompra> Historico { get; private set; } = new List<HistoricoCompra>();
        public void Pagar(double amount)
        {
            if(amount > Valor)
            {
                throw new Exception("ERROR");
            }
            Valor -= amount;
            Historico.Add(new HistoricoCompra(amount, DateTime.Now));
        }
        public override string ToString()
        {
            return $"A conta {Id} tem o valor R${Valor.ToString("F2")}";
        }
        public void GetHistorico()
        {
            foreach(HistoricoCompra h in Historico)
            {
                Console.WriteLine(h);
            }
        }
    }
}
