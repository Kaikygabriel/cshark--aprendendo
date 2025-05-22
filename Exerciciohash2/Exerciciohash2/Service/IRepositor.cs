using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerciciohash2.Service
{
    internal interface IRepositor
    {
        List<string> Fazer(string path);
    }
}
