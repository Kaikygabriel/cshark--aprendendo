namespace TabuadaInterativa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tabuada();
        }
        static void Tabuada()
        {
            List<int> certo = new List<int>();
            int[] num = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.Write("Escolha um numero para tabuada :");
            int numEscolhido = int.Parse(Console.ReadLine());
            int pergustas = 0;
            List<int> passado = new List<int>();
            while(pergustas < 5)
            {
                Random aleatorio = new Random();
                int numAleatorio = num[aleatorio.Next(num.Length - 1)];
                foreach(int i in passado)
                {
                    while(i == numAleatorio)
                    {
                        numAleatorio = num[aleatorio.Next(num.Length - 1)];
                    }
                }
                Console.WriteLine($"Quantos é {numEscolhido} X {numAleatorio}");
                int resposta = int.Parse(Console.ReadLine());
                int resultado = numAleatorio * numEscolhido;
                if(resposta == resultado)
                {
                    Console.WriteLine("Correto !");
                    certo.Add(1);
                }
                else
                {
                    Console.WriteLine("Errado !");
                }
                pergustas++;
                passado.Add(numAleatorio);
            }
            Console.WriteLine($"Voce acertou {certo.Count} de 5");
        }
    }
}
