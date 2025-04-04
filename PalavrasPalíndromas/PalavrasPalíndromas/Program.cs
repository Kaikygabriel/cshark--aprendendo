namespace PalavrasPalíndromas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            palindromas("ana");
        }
        static void palindromas(string palavra)
        {
            List<char> list = new List<char>(); 
            for(int i = 0; i < palavra.Length; i++)
            {
                list.Add(palavra[i]);
            }
            List<char> list2 = new List<char>();
            for (int i = list.Count -1; i > -1; i--)
            {
                char index = palavra[i];
                list2.Add(index);
            }
        
            if (list2.SequenceEqual(list))
            {
                Console.WriteLine($"A palavra {palavra} é palindromas");
            }
            else
            {
                Console.WriteLine("Não  é palindromas");
            }
        }
    }
}


