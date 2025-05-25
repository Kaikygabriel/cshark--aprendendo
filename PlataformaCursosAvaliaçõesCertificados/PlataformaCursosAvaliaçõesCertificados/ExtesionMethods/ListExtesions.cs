using System.Collections.Generic;
using System.Text;


namespace System
{
    internal static class ListExtesions
    {
        public static void GetListWrite<T>(this IEnumerable<T> list)
        {
            foreach(var l in list)
                Console.WriteLine(l);
        }
    }
}
