using System.Xml;
using System;

namespace poo
{
    internal class Program
    {
         static void Main()
        {
            Celular motorola = new Celular("Motorola-MotoG23", 1000f, 6f , "ryzen 5", 6.2f);
            Celular samsung = new Celular("Samsung-a12", 800f, 4f, "ryzen 7", 6.5f);
            Console.WriteLine("===============================");
            jogos gta = new jogos("gta5", "rockstar", 70f, "ação violencia");
            jogos minecraft = new jogos("Minecraft", "microsoft", 100f, "ação aventura");
            Console.WriteLine("===============================");
            Carro corsa = new Carro("corsa", "Chefrole", "v8", 1000f, 4, 2010);
            corsa.buzina1();
            //criando uma varialel do tipo carro que recebe o objeto carro
            Carro.buzina();
        }
    }
}
