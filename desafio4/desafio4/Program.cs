using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace desafio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<char> list = alfabeto(12);
            foreach(char c in list)
            {
                Console.WriteLine(c);
            }
        }
        static List<char> alfabeto(int num)
        {
            List<char> alfabeto = new List<char>() {'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','t','w','y','z'};
            List<char> list = new List<char>();
            for (int i = 0; i < num; i++) 
            {
                
                if(num > 0 && num < 26)
                {
                    list.Add(alfabeto[i]);
                }
            }
            return list;
        }
    }
}
