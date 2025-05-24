using System;


namespace MetodosExtendidos
{
    internal class Program
    {
        static void Main()
        {
            DateTime dt = new DateTime(2018,11,16,8,10,45);
            Console.WriteLine(dt.ElapsedTime());
            List<string> nomes = new List<string> { "kaiky", "gabrile", "alves" };
            nomes.GetList<string>();
            string frase = "testando ola ola oal";
            Console.WriteLine(frase.Cut(8));
            string data = "16-03-2008";
            DateTime aniversario = data.ToDateTime();
            Console.WriteLine(aniversario);
        }
    }
}
