using System.Linq.Expressions;
using System.Reflection.Metadata;
using System.Runtime.Serialization.Formatters.Binary;

namespace DEsafioMatriz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CriarMatriz();
        }
        static void CriarMatriz()
        {
            int linha = int.Parse(Console.ReadLine());
            int coluna = int.Parse(Console.ReadLine());
            int[,] matriz = new int[linha, coluna];
            for (int i = 0; i < linha; i++)
            {
                string[] add = Console.ReadLine().Split(' ');
                for (int a = 0; a < coluna; a++)
                {
                    matriz[i, a] = int.Parse(add[a]);
                }
            }
            Console.WriteLine("Numero que quer pegar");
            int num = int.Parse(Console.ReadLine());
            int linhanum = -1;
            int colunanum = -1;
            bool existe = false;
            for (int i = 0; i < linha; i++) 
            {
                for (int a = 0; a < coluna; a++)
                {
                    if (matriz[i, a] == num)
                    {
                        colunanum = a;
                        linhanum = i;
                        existe = true;
                    }
                }
            }
            if (existe)
            {
                int? cima;
                int? baixo;
                int? esquerda;
                int? direita;

                if(linhanum != -1 || colunanum != num)
                {
                    //cima
                    if ( linhanum - 1 < linha && linhanum !> linha)
                    {
                        cima = matriz[linhanum - 1, colunanum];
                        Console.WriteLine("O numero de cima é " + cima);
                    }
                   
                    //baixo
                    if (linha > linhanum + 1)
                    {
                        baixo = matriz[linhanum + 1, colunanum];
                        Console.WriteLine("O numero de baixo é " + baixo);
                    }
                    
                    //esquerda
                    if (coluna < colunanum - 1 && colunanum - 1 < colunanum)
                    {
                        esquerda = matriz[linhanum, colunanum - 1];
                        Console.WriteLine("O numero da esquerda é " + esquerda);
                    }
                   
                    //direita
                    if (colunanum > colunanum + 1)
                    {
                        direita = matriz[linhanum, colunanum +1];
                        Console.WriteLine("O numero da direita é " + direita);
                    }
                    
                }
                
                
              
            }
            else
            {
                Console.WriteLine("Não achei o numero");
            }
        }
    }
}
