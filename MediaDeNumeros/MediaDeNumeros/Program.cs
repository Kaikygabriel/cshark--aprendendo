using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaDeNumeros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Media();
        }
        static void Media()
        {
            List<int>list = new List<int>() {1,2,3};
            int soma=0;
            foreach (int i in list)
            {
                soma += i;
            }
            int Final = soma/list.Count;   
            Console.WriteLine(Final);
        }
    }
}
