using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alocacao2.Entity
{
    internal class CarRental
    {
        public CarRental() { }

        public CarRental(DateTime entrada, DateTime entregua,Veiculo model)
        {
            Entrada = entrada;
            Entregua = entregua;
            Model = model;
        }

        public DateTime Entrada { get; private set;}
        public DateTime Entregua { get; private set;}
        public Veiculo Model { get; private set;} 
        public Invoice Invoice { get;  set; }
    }
}
