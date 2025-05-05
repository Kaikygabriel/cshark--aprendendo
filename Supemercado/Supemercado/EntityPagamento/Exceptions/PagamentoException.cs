using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supemercado.Entity.Exceptions
{
    internal class PagamentoException : ApplicationException
    {
        public PagamentoException(string Menssage) :base(Menssage)
        { }
    }
}
