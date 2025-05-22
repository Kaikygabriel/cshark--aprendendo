using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerciciohash2.Service
{
    internal sealed class ServiceRepositorio : IRepositor
    {
        public List<string>  Fazer(string path)
        {
            List<string> list = new List<string>();
            using(StreamReader rd = new StreamReader(path))
            {
                while (!(rd.EndOfStream)) 
                  list.Add(rd.ReadLine());
            }
            return list;
        }
    }
}
