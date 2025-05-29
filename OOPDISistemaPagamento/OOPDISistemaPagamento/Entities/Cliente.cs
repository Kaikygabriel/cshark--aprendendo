using System;
using System.Collections.Generic;
using System.Formats.Tar;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDISistemaPagamento.Entities
{
    internal class Cliente : Usuario
    {
        public List<Pagamento> Historico { get; private set; } = new List<Pagamento>();
        public void ReceberPagamento(Pagamento p)
        {
            Historico.Add(p);
        }

        public override int GetHashCode()
        {
            return CPF.GetHashCode();
        }
        public override bool Equals(object? obj)
        {
            if (!(obj is Cliente))
                throw new Exception();
            Cliente other = (Cliente)obj; 
            return CPF.Equals(other.CPF);
        }
    }
}
