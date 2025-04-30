using System.Numerics;

namespace ExecaoExercicio
{
    internal class Program
    {
        static void Main()
        {
            try
            {
                int num = int.Parse(Console.ReadLine());
                int num2 = int.Parse(Console.ReadLine());
                Console.WriteLine(num / num2);
            }
            catch (DivideByZeroException)
            {
                //erro de divisão por zero
                //sempre e bom colocar uma exceção especifica , para implementar aplicações especifica caso isso aconteca
                Console.WriteLine("Não da pra dividir por zero");
            }
            catch (Exception e)
            {
                //atraves do e , pega o error que aconteceu e pode mostrar o erro atraves do e.Menssage
                Console.WriteLine($"Ocorreu o erro {e.Message}");
            }
        }
    }
}
