using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorDeInvestimento.Entidade
{
    internal class Selic
    {
        public string data;
        public float valor;

        public Selic()
        {
        }

        public Selic(string data, float valor)
        {
            this.data = data;
            this.valor = valor;
        }
    }
}
