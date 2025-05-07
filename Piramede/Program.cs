namespace Piramede
{
    internal class Program
    {
        static void Main()
        {
            Piramede(6);
        }
        static void Piramede(int Altura)
        {

            for (int i = 1; i <= Altura; i++)
            {
                for (int a = 1; i <= Altura; a++)
                {
                    System.Console.Write("#");
                    if (a == i) break;
                }
                System.Console.WriteLine("");
            }
        }
    }
}