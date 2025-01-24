using System;

namespace constante.cs
{
    internal class Programa
    {
      
        static void Main()
        {

            

            // exemplo de constante, tem que colocar const e depois indicar o tipo dela ex(const String kaiky = "nome";)
            const int numero = 1;
            Console.WriteLine(numero);


            String[] nome = { "kaiky", "kg" };
            Random random = new Random();
            Console.WriteLine(nome[random.Next(nome.Length)]);


            //Operadores logicos 
            int a = 1;
            int b = 10;
            int soma = a + b;
            Console.WriteLine(soma);

            //cuidado 
            //se dividir 6/2 = 4 // tipo int
            //porem se dividir 5/2 = 2.5f // tipo float 

            float NumeroDividido = 5 / 2f;
            Console.WriteLine(NumeroDividido);

            float numero6 = 6f / 2; //=> numero float dividido por int sempre vai dar float ex( 3.0f )
            Console.WriteLine(numero6);

            int NumeroDividido2 = 5 / 2;
            // vai dar 2
            // se dividir dois numeros inteiros no csharp o resultado sempre vai ser inteiro (ele ve que o resultado vai dar 2.5 e corta pra 2) 


            Console.WriteLine("insira seu nome abaixo");
            string nome2 = Console.ReadLine();
            Console.Write("Olá " +nome2);
        }
    }
}