using System;

namespace ConsoleApp3;

class program
{
    static void Main()
    {
        List<string> nome = new List<string>() {"Kaiky","kg"};
        Console.WriteLine(nome[1]);
        int num = 13;
        Console.WriteLine(Testar(num));
    }
    public static string Testar(int num)
    {
        if (Retornar(num))
        {
            return $"o valor e maior que zero {num}";
        }
        else
        {
            return "valor não e maior que zero";
        }
    }
    public static bool Retornar(int num)
    { 
    if(num != 0 && num > -1)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}