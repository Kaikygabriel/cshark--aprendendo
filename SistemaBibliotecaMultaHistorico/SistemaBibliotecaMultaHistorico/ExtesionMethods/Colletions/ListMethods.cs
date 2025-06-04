namespace SistemaBlibiotecaMulta.ExtesionMethods;

public static class ListMethods
{
    public static void GetList<T>(this IEnumerable<T> colletion)
    {
        foreach (var c in colletion)
        {
            Console.WriteLine(c);
        }
    }
}