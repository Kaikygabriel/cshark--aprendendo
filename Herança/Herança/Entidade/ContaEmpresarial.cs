using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herança.Entidade
{
    internal class ContaEmpresarial : ContaBancaria
    {
        public double EmprestimoLimite;

        public ContaEmpresarial()
        {
        }

        public ContaEmpresarial(double emprestimoLimite,string titular,int id,double saldo):base(id,titular,saldo)
        {
            EmprestimoLimite = emprestimoLimite;
        }

        public void Emprestimo(double valor)
        {
            if (valor < EmprestimoLimite)
            {
                Saldo += valor;
                EmprestimoLimite -= valor;
            }
        }
    }
}
