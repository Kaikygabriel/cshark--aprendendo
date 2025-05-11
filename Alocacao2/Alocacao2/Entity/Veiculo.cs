using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alocacao2.Entity
{
    internal  class Veiculo
    {
        public Veiculo() { }
        public Veiculo(string modelo)
        {
            Modelo = modelo;
        }
        public string Modelo { get;  set; }
    }
}
