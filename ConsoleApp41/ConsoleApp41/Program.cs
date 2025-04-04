namespace ConsoleApp41
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SomaNumeros(432);
        }
        static void SomaNumeros(int num)
        {

            List<char> list = new List<char>();
            string numero = num.ToString();
            for (int i = 0; i < numero.Length; i++)
            {
                list.Add(numero[i]);
            }
            int soma1 = 0;
            foreach (char c in list)
            {
              
                soma1 =  int.Parse(c.ToString()) + soma1;
            }
            Console.WriteLine($" {num} é {soma1}");
        }
    }
}
