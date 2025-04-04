namespace Arranjo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a quantidade de Produtos");
             int n = int.Parse(Console.ReadLine());
        
            Produto[] craft = new Produto[n];
            for (int i = 0; i < craft.Length; i++)
            {
              Console.Write($"Nome : ");
              string nome = Console.ReadLine();
                Console.Write("Preço R$");
                double valor = double.Parse(Console.ReadLine());
              craft[i] = new Produto(nome,valor);
                
            }
            double media = 0;
            for (int i = 0; i < craft.Length; i++)
            {
                media += craft[i].Valor;
            }
            Console.WriteLine($"A media é R${(media / n).ToString("F2")}");
        }
    }
}
