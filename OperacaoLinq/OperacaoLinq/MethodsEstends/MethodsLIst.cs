using System.Collections.Generic;

namespace OperacaoLinq.MethodsEstends
{
    internal static class System
    {
        public static void GetList<T>(this IEnumerable<T> list,string msg)
        {
            Console.WriteLine(msg);
            foreach (T item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(" ");
        }
    }
}
