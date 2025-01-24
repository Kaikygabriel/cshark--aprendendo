using System;
using System.ComponentModel.Design;

namespace treino.cs
{
    internal class TreinoProgram
    {
        static void Main()
        {
            int num = 1995;
            Console.WriteLine(Testando(num));
        }
        public static string Testando(int numero)
        {
           if(numero >= 1000)
            {
                float pdecimal = numero % 1000f;
                 int arredondar = (int)Math.Round(pdecimal / 10) *10;
                return  $"{numero/1000}k{arredondar }";
            }
            else if(numero >= 1000000)
            {
                float partedecimal = numero % 1000000;
                return $"{numero / 100000000}m{partedecimal}";
            }  
            else if(numero >= 1000000000)
            {
                float partedecimal = numero % 1000000000;
                return $" {numero/100000000000}b{partedecimal}";
            }
            else
            {
                return "Não foi capaz de ver seu numero";
            }
        } 
    }
}
