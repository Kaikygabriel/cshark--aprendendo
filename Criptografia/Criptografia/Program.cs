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

            List<int> list = Cript("kaiky-gabriel-alves");
            foreach (int l in list)
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
        static List<int> Cript(string palavra)
        {
            List<char> list = new List<char>() { '-', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 't', 's', 'v', 'w', 'x', 'y', 'z', '0' };


            List<char> list2 = new List<char>();
            for (int i = 0; i < palavra.Length; i++)
            {
                list2.Add(palavra[i]);
            }

            List<int> list3 = new List<int>();
            foreach (char c in list2)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (c == list[i])
                    {

                        list3.Add(list.IndexOf(list[i]) + 1);
                    }
                }
            }
            return list3;
        }
        static List<char> CriptReverse(List<int> nome)
        {
            List<char> list = new List<char>() { '-', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 't', 's', 'v', 'w', 'x', 'y', 'z', '0' };
            List<char> list3 = new List<char>();
           
            foreach (int c in nome)
            {
                foreach (char l in list)
                {
                   
                    if (c == list.IndexOf(l))
                    {

                        list3.Add(list[c]);
                    }

                }
            }
            List<char> list4 = new List<char>();
            foreach (char a in list3)
            {
                foreach(char l in list)
                {
                    int index = list.IndexOf(l);
                    if(a == l)
                    {
                        list4.Add(list[index - 1]);
                    }
                }
            }

            return list4;
        }
       

    }

}