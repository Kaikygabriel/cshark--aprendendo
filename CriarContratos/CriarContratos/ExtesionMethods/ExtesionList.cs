using System.Collections.Generic;
using System.Text;

namespace System
{
    public static class ExtesionList
    {
        public static void GetList<T>(this IEnumerable<T> list) 
        {
            foreach(var item in list)
                Console.WriteLine(item);
        }
    }
}
