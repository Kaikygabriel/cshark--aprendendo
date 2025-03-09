using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delta
{
    internal class Program
    {
         static int a = 2;
         static int b = 7;
         static int c = 8;
        static void Main(string[] args)
        {
            Contas.Resu(Contas.Delta(b,a,c),b,a );
        }  
    }
}
