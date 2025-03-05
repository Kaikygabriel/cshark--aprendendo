using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.ComponentModel;
using System.Collections;
namespace Criptografia
{


    class Program
    {
        static void Main()
        {

            List<char> list =Cript("entao-ta-dificil");
            foreach (char l in list)
            {
                Console.Write(l);
            }
            Console.WriteLine("");
            List<char> list2 = CriptReverse(list);
            foreach (char l in list2)
            {
                Console.Write(l);
            }
        }
        static List<char> Cript(string palavra)
        {
            List<char> list = new List<char>() {'-','a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','t','s','v','w','x','y','z'};
            
            
            List<char> list2 = new List<char>();
            for (int i = 0; i < palavra.Length; i++)
            {
                list2.Add(palavra[i]);
            }
           
            List<char> list3 = new List<char>();
            foreach (char c in list2)
            {
                for (int i = 0 ; i < list.Count;i++)
                {
                    if(c == list[i])
                    {
                        list3.Add(list[i + 1]);
                    }
                }
            }
            return list3;
        }
        static List<char> CriptReverse(List<char> nome)
        {
            List<char> list = new List<char>() {'-', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 't', 's', 'v', 'w', 'x', 'y', 'z' };
            List<char> list3 = new List<char>();
            foreach (char c in nome)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (c == list[i])
                    {
                        list3.Add(list[i - 1]);
                    }
                }
            }
            return list3;
        }
    }
}