using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlibiotecaSistemaa.Entities.Exception
{
    internal class DominoException:ApplicationException
    {
        public DominoException(string Menssage) :base(Menssage) { }
    }
}
