using System;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
namespace introducaoDelegate
{
    internal class Program
    {
        delegate int Maior<T>(T p, T p2);
        delegate void CalcularMais (double p1, double p2);
        delegate bool Igual<T>(T p1, T p2);
        static void Main()  
        {
            Igual<string> num = (p1,p2)=>p1.Equals(p2);
            Console.WriteLine(num("oi","oi"));

            List<int>a = new List<int> { 1,2,3,4};
            Maior<int> maiorQue3 =(p1,p2) => p1.CompareTo(p2);
            Comparison<string> compara = (p1, p2) => p1.CompareTo(p2);
            Console.WriteLine(compara("oi","oi"));
            Console.WriteLine(maiorQue3(1,1));
            CalcularMais somas = (p, p2) =>
            {
                double soma = p + p2;
                Console.WriteLine(soma);
            };
            somas(1,2);
        }
    }
}
