using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaiorMenorNumero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() {2,6,7,8,4};
            MaiorMenor(list);
        }
        static void MaiorMenor(List<int> num)
        {
            int maior = num.Max();
            int menor = num.Min();
            int MaiorFuncao = 0;
            int MenorFuncao = 0;
            List<int> list = new List<int>();
            while(MaiorFuncao != maior && MenorFuncao != menor)
            {
                for (int i = 0; i <= num.Count;i++)
                {
                    int NumeroDaFrente = Math.Abs(i + 1);
                    if (NumeroDaFrente <= num.Count - 1)
                    {


                        if (num[i] < num[NumeroDaFrente])
                        {
                            MaiorFuncao = num[NumeroDaFrente];

                        }


                        if (num[i] > num[NumeroDaFrente])
                        {
                            MenorFuncao = num[NumeroDaFrente];
                            if (list.Count == 0)
                            {
                                list.Insert(0, num[NumeroDaFrente]);

                            }
                            else
                            {
                                if (list[0] < MenorFuncao)
                                {
                                    MenorFuncao = list[0];

                                }
                                else
                                {
                                    list[0] = MenorFuncao;

                                }
                            }
                        }
                        else
                        {
                            MenorFuncao = num[i];
                            if (list.Count == 0)
                            {
                                list.Insert(0, num[i]);

                            }
                            else
                            {
                                if (list[0] < MenorFuncao)
                                {
                                    MenorFuncao = list[0];

                                }
                                else
                                {
                                    list[0] = MenorFuncao;

                                }
                            }
                        }
                    }
                    
                    
                }
            }
            Console.WriteLine($"O maior numero é {MaiorFuncao} eo menor é {MenorFuncao}");
        }
    }
}

