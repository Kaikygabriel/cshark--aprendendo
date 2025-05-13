using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioContratoInterface.Entity.Exception
{
    internal class DominioException: ApplicationException
    {
        public DominioException(string Menssage): base(Menssage) { }
    }
}
