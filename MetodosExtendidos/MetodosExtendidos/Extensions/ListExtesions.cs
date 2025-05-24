using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System
{
    internal static class ListExtesions
    {
        public static void GetList<T>(this IEnumerable<T> list) 
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
