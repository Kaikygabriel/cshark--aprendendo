namespace System
{
    public  static class MethodsList
    {
        public static void GetList<T>(this IEnumerable<T> List)   
        {
            foreach (T item in List)
                Console.WriteLine(item);
        }
    }
}