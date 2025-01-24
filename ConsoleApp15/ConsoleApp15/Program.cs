using System;
using System.Collections.Generic;//adiciona tipos de estrutura de dados(lista , dicionarios , sets , hasjtables)
using System.Linq; // filtagrem- remoção etc da lista -- blibioteca
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    internal class Program
    {
        static void Main()
        {
            // string kaka; > null nao tem valor nenhum
            List<string> jogos = new List<string>() {"Minecraft","GTA","Roblox"};
            jogos.Add("HOTWEELS");
            jogos[2] = "fifa";
            Console.WriteLine(jogos[0]); 
            //sempre que não for um tipo primitivo do csharp(string , int , float, chat, double),tem que colocar o new
            foreach (string jogo in jogos)
            {
                Console.WriteLine(jogo);    
            }
            Console.ReadLine();
        }
    }
}
