using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics2.Service
{
    internal class ServiceList 
    {
        public T CalculationService<T>(List<T> lista) where T : IComparable
        {
            lista.Sort();
            return lista[lista.Count -1];
        }
    }
}
