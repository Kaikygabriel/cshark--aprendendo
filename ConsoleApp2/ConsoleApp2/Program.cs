using System;

namespace ConsoleApp2;
class Program
{   
    //universo fechado de posibilidades
    //so pode trabalhar com os valores que colocar dentro do enum
    //todos items tem um valor por tras, começando por zero(0,1,2)
    //valor não precisa estar entre strings
    //semelhante ao array
    //pode ser personalizado o indice
    enum cores
    {
       azul = 0,verde = 1,vermelho = 2
    }
    static void Main()
    {
        // so pode colocar valor que esta dentro do enum 
        cores corfav = cores.verde;
        cores cor2 = cores.azul;
        Console.WriteLine(cor2);
        Console.WriteLine(corfav);
        //ta convertendo o corfav em numero, do index
        Console.WriteLine((int)corfav);

        //convertendo um numero para o enum cores
        Console.WriteLine((cores)2);
        Console.ReadLine();
    }
   
}  