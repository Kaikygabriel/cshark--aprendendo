
namespace ContarVogais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ler("mEu-nome-e-KAIKY");
        }
        static void Ler(string palavra)
        {
            List<char> list = new List<char>() {'a','e','i','o','u','A','E','I','O','U'};
            int somarVogal = 0;
            for(int i = 0; i < palavra.Length; i++)
            {
                foreach (char c in list)
                {
                    if (palavra[i] == c)
                    {
                        somarVogal += 1;
                    }
                }
            }
            Console.WriteLine($"o numero de vogal é {somarVogal}");
        }
    }
}
