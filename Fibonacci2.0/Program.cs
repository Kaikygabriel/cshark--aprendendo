namespace  Fibonacci2._0
{
    public class Program
    {
        static void Main()
        {
            Fibonacci(10);
        }
        static void Fibonacci(int Atequando)
        {
            List<int> list = new List<int>();
            int numAnterior = 0;
            int soma = 0;
            for (int i = 1; i <= Atequando; i++)
            {
                int n1 = 0;
                int n2 = 1;
                if (i == 1)
                {
                    n1 = 0;
                    n2 = 1;
                    numAnterior = n2;
                    soma = n1 + n2;
                   
                    list.Add(n2);
                }
                else
                {
                    n1 = numAnterior;
                    n2 = soma;
                    numAnterior = n2;  
                    soma = n1 + n2;
                    
                    list.Add(n2);
                }
            }
            foreach(int num in list)System.Console.Write($"{num},");
        }
    }
}
