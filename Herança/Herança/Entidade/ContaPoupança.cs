using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herança.Entidade
{
    internal class ContaPoupança : ContaBancaria
    {
        public ContaPoupança(){ }
        public ContaPoupança(string titular,int id, double saldo,double taxa):base(id,titular,saldo)
        {
            Taxa = taxa;
        }

        public double Taxa { get; set; }
        public void CalcularPoPança()
        {
            Saldo *= Taxa; 
        }
    }
}
