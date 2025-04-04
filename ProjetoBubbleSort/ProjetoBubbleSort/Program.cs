using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBubbleSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 1, 8, 9, 2, 3, 5, 7, 6, 4 };
            List<int> listSort = BubbleSort(list);
            foreach(int l in listSort)
            {
                Console.Write(l + " ");           
            }
        }
        static List<int> BubbleSort(List<int> list)
        {
            List<int> listanova = list;
            List<int> listanova2 = list;
            listanova2.Sort();
            while (listanova != listanova2)
            {

                for (int i = 0; i <= list.Count; i++)
                {


                    int exato = i;
                    int proximo = exato + 1;

                    if (proximo < list.Count)
                    {
                        if (list[exato] < list[proximo])
                        {
                            int frente = list.IndexOf(list[exato]);
                            list.Remove(list[exato]);
                            list.Insert(frente, list[exato]);
                        }
                        if (list[exato] > list[proximo])
                        { 
                            int frente = list.IndexOf(list[proximo]);
                            list.Remove(list[exato]);
                            list.Insert(frente, list[exato]);
                        }
                    }

                }
            }
        

            return listanova;
        }
    }
}
