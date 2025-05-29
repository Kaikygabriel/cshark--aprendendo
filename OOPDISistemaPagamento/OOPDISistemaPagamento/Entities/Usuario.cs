using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDISistemaPagamento.Entities
{
    internal abstract class Usuario
    {
        protected Usuario() { }

        protected Usuario(string nome, string cPF)
        {
            Nome = nome;
            CPF = cPF;
        }

        public double Saldo { get; set; }
        public string Nome { get; private protected set; }
        public string CPF { get; private protected set; }

        public override string ToString()
        {
            return $"{Nome} -- {CPF}";
        }
    }
}
