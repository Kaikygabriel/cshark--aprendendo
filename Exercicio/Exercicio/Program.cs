using System.Globalization;

namespace Exercicio
{
    internal class Program
    {
        static void Main()
        {
            //Pessoa kk = new Pessoa("kaiky", 16);
            //Pessoa gabriel = new Pessoa("Gabriel", 17);
            //Pessoa.Contar(kk, gabriel);
            List<Produtos> produtos = new List<Produtos>();
            Console.WriteLine("Nome");
            string nome = Console.ReadLine();
            Console.WriteLine("preço");
            double preco = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine("Quantidade");
            int quantia = int.Parse(Console.ReadLine());
            produtos.Add(new Produtos(nome,preco));
            produtos[0].ValorTotalEstoque();
            int quantia1 = int.Parse(Console.ReadLine());

            produtos[0].AdicionarProdutos(quantia1);
        }
    }
}
