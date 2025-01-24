using System;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.FileIO;

namespace retorno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Mercado(10, "maça"));
            Console.WriteLine(Somar(10, 10, 10));
            // ou
            int soma1 = Somar(10, 10, 10);
            Console.WriteLine(soma1);
            //Pode colocar dentro de uma variavel 

            Console.ReadLine();
        }
        static string Mercado(int preco,string fruta)
        { 
           int precoabs = Math.Abs(preco);
            return "O preço da fruta " + fruta + ", é de " + precoabs + "R$ .";
        }
        static int Somar(int num1, int num2, int num3) 
        {
            int resultado = num1 + num2 + num3;
            return resultado;
            //A informação que voce passa antes do nome função, eo tipo dela(de retorno)
            //void não retorna nada
            //caso queira retornar algo tem que falar o tipo de retorno, funciona que nem o tipo de variavel(int, string, float etc...)
            //return e uma palavra reservada, so pode ser ultilizada dentro de função, que serve para retorna um valor(pode retornar qualquer coisa des que corresponda com meu tipo)
            //sempre que colocar um tipo, e obrigatorio colocar algo para retornar esse tipo
            //todo codigo abaixo do retorno, não e executado(no mesmo bloco de codigo)
        }
    }

}