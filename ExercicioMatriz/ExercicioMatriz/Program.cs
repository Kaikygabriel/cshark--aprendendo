namespace ExercicioMatriz
{
    internal class Program
    {
        static void Main()
        {
            CriarMatriz();
        }
        static void CriarMatriz()
        {
            Console.WriteLine("Numero de linhas e colunas");
            int numColunaLinha = int.Parse(Console.ReadLine());
            int[,] matriz = new int[numColunaLinha,numColunaLinha]; 
            for(int i = 0; i <= numColunaLinha -1; i++)
            {
                string[] sla = Console.ReadLine().Split(" ");// ele vai recortar oque estiver com espaço e adicionar a variavel
                for(int j = 0; j <= numColunaLinha -1 ; j++)
                {
                
                    matriz[i, j] = int.Parse(sla[j]);
                    
                }
            }
            int soma = 0;
            List<int> Numdiagonal = new List<int>();
            for (int i = 0; i <= numColunaLinha - 1; i++)
            {
               Numdiagonal.Add(matriz[i, soma]);   
               soma += 1;
            }
            List<int> Numnegativo = new List<int>();
            for (int i = 0; i <= numColunaLinha - 1; i++)
            {
                for (int j = 0; j <= numColunaLinha - 1; j++)
                {
                    if (matriz[i,j] < 0)
                    {
                        Numnegativo.Add(matriz[i, j]);

                    }
                }
            }
            
            Console.WriteLine("Os numeros na diagonal são :");
            foreach (int i in Numdiagonal)
            {
                Console.Write($" {i}");
            }
            Console.WriteLine("");
            Console.WriteLine($"Os numeros negativos são :{Numnegativo.Count}");
            
        }
    }
}
