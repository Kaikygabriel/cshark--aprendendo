using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = cripto("kaiky");
            foreach (int l in list)
            {
                Console.Write($" {l} ");
            }
            List<char> listLer = ler(list);
            foreach (char l in listLer)
            {
                Console.Write(l);
            }
        }
        static List<int> cripto(string texto)
            
        {
            List<int> list = new List<int>();
            List<char> alfabeto = new List<char>(){'*','a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','q','r','s','t','w','x','y','z'};
            for(int i = 0; i < texto.Length; i++)
            {

                foreach(char a in alfabeto)
                if (texto[i] == a)
                {
                    int index = alfabeto.IndexOf(a);
                    list.Add(index);
                }
            }
            return list;
        }
        static List<char> ler(List<int> num)
        {
            List<char> alfabeto = new List<char>() { '*', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'q', 'r', 's', 't', 'w', 'x', 'y', 'z' };
            List<char> list = new List<char>();
            for(int i = 0;i < num.Count; i++)
            {
                foreach (char a in alfabeto)
                {
                    if (num[i] == alfabeto.IndexOf(a))
                    {
                        list.Add(a);
                    }
                }
            }
            return list;
        }
    }
}
