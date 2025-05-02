using System;

namespace BuscaBinario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Buscar(91);
        }
        static void Buscar(int num)
        {
            List<int> lista = new List<int> { 2, 5, 8, 12, 16, 23, 38, 56, 72, 91 };
            double y = (lista.Count / 2) - 1;
            int v = (int)Math.Round(y);
            while (lista[v] != num)
            {
                if (num > lista[v])
                {
                    int tamanho = lista.Count - 1;
                    List<int> lista2 = new List<int>();
                    for (int i = v; i <= tamanho; i++)
                    {
                        lista2.Add(lista[i]);
                    }
                    lista = lista2;
                    if (lista.Count % 2 == 1)
                    {
                        v = lista.Count / 2; // pegando o meio da lista novamente
                    }
                    else
                    {
                        v = (lista.Count / 2) - 1; // pegando o meio da lista novamente
                    }
                }
                else
                {
                    int tamanho = lista.Count - 1;
                    List<int> lista2 = new List<int>();
                    for (int i = 0; i <= v; i++)
                    {
                        lista2.Add(lista[i]);
                    }
                    lista = lista2;
                    if (lista.Count % 2 == 1)
                    {
                        v = lista.Count / 2; // pegando o meio da lista novamente
                    }
                    else
                    {
                        v = (lista.Count / 2) - 1; // pegando o meio da lista novamente
                    }
                }

            }
            Console.WriteLine("Achou -" + lista[v]);
        }
    }
}
