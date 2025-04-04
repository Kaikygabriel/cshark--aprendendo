using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomaDeMatriz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> lista = new List<int>() {2,4 };
            List<int> list2 = new List<int>() { 1, 2 };
            Somar(lista, list2);
        }
        static void Somar(List<int> lista1, List<int> lista2)
        {
            List<int>lista3 = new List<int>();
            for (int i = 0; i < lista1.Count; i++)
            {
                for (int a = 0; a < lista1.Count; a++)
                {
                   if(a == 0)
                    {
                   lista3.Add(lista1[a] + lista2[i]);
                        break;
                    }
                   else
                    {
                        lista3.Add(lista1[a] + lista2[i]);
                        break;
                    }

                }

            }
            foreach (int i in lista3)
            {
                Console.Write(i);
            }
           
        }
    }
}
