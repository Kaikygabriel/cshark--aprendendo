
using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvertendoStringEmContas
{
    internal class Program
    {

        static void Main(string[] args)
        {
            ConverterCOntar("5*4");
        }
        static void ConverterCOntar(string conta)
        {
            string operacao = null;
            List<char> list = new List<char>();
            for (int i = 0; i < conta.Length; i++)
            {
                list.Add(conta[i]);
            }
            List<char> list3 = list;

            for(int c = 0; c < list3.Count; c++)
            {
                if(list3[c].ToString() == "+")
                {
                    operacao = "mais";
                    list.Remove(list3[c]);
                }
                if (list3[c].ToString() == "-")
                {
                    operacao = "menos";
                    list.Remove(list3[c]);
                }
                if (list3[c].ToString() == "*")
                {
                    operacao = "vezes";
                    list.Remove(list3[c]);
                }
                if (list3[c].ToString() == "/")
                {
                    operacao = "divisao";
                    list.Remove(list3[c]);
                }
            }
            List<int> list2 = new List<int>();
            foreach (char i in list)
            {
                list2.Add(int.Parse(i.ToString()));
            }
           
            int inicial= 0;
            for(int l = 0; l < list2.Count; l++)
            {
                if(l == 0)
                {
                    if(operacao == "mais")
                    {
                    inicial = list2[l] + list2[l +1 ];
                    }
                    if (operacao == "menos")
                    {
                        inicial = list2[l] - list2[l + 1];
                    }
                    if (operacao == "vezes")
                    {
                        inicial = list2[l] * list2[l + 1];
                    }
                    if (operacao == "divisao")
                    {
                        inicial = list2[l] / list2[l + 1];
                    }
                }
            }
            Console.WriteLine(inicial);
        }
    }
}


