namespace Nuable
{
    internal class Program
    {
        static void Main(string[] args) 
        {
            double? y = null;
            double? x = 10.0;
            Console.WriteLine(y.GetValueOrDefault()); // se caso o valor do y não existir vai pegar o valor padrao do tipo y (double) 
            Console.WriteLine(x.GetValueOrDefault()); //o valor do x existe então ele não  coloca o valor padrão

            Console.WriteLine(y.HasValue);// testa se o y tem valor ou não
            Console.WriteLine(x.HasValue);

            Console.WriteLine(x.Value);

            double z = y ?? 0.0; // caso o x for null, z recebe 0.0
        }
    }
}
