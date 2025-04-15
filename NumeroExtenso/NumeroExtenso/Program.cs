

using System;
using System.IO.Pipes;

namespace NumeroExtenso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ano que nasceu :");
            int ano = int.Parse(Console.ReadLine());
            DateTime anoAtual = DateTime.Now;
           
            int idade = Math.Abs(ano - anoAtual.Year);
          
            NumeroExtenso(idade);
        }
        static void NumeroExtenso(int numero)
        {
            string[] unidades = { "", "um", "dois", "três", "quatro", "cinco", "seis", "sete", "oito", "nove","dez" };
            string[] dezenas = {"","","vinte", "trinta", "quarenta", "cinquenta", "sessenta", "setenta", "oitenta", "noventa" };
            string[] especiais = { "dez", "onze", "doze", "treze", "quatorze", "quinze", "dezesseis", "dezessete", "dezoito", "dezenove" };
            string[] centenas = { "", "cento", "duzentos", "trezentos", "quatrocentos", "quinhentos", "seiscentos", "setecentos", "oitocentos", "novecentos" };

            if (numero > 10 && numero <100)
            {
                Console.WriteLine(numero);
                int dezena = numero / 10;
                int unidade =  numero % 10;
                if(dezena == 1)
                {
                    Console.WriteLine(especiais[unidade]  + " Anos");
                }
                else
                {
                    Console.WriteLine(dezenas[dezena] +" e "+ unidades[unidade] +" Anos" );
                }

            }
            else if( numero >= 100 && numero <1000)
            {
                Console.WriteLine(numero);
                int centena = numero / 100;
                
                int dezena = (numero / 10) % 10;
               
                int unidade = (numero % 100) % 10;
                Console.WriteLine($"{centenas[centena]} e {dezenas[dezena]} e {unidades[unidade]} anos ");
            }
            else
            {
                
                Console.WriteLine(unidades[numero] + " Anos");

            }
        }
    }
}
