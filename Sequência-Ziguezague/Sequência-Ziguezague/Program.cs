using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Sequência_Ziguezague
{
    internal class Program
    {
        static void Main()
        {
            List<int> numeros = new List<int>() { 2, 4, 5, 3, 1 };
            Ziguezague(numeros);
        }
        static void Ziguezague(List<int> numeros)
        {
            numeros.Sort();
 
            // Passo 2: Garantir que os números nas posições ímpares sejam maiores que os pares anteriores
            for (int i = 0; i < numeros.Count; i ++)
            {
                if ((i + 1) <= 4)
                {
                    // Trocar o número de índice ímpar com o número de índice par anterior, se necessário
                    if (numeros[i] < numeros[i + 1])

                    {
                        // Troca os elementos
                        int temp = numeros[i];
                        numeros[i] = numeros[i + 1];
                        numeros[i + 1] = temp;
                    }
                }
            }

            // Exibir a sequência final
            Console.WriteLine("Sequência Ziguezague:");
            foreach (int num in numeros)
            {
                Console.Write(num + " ");
            }

        }
    }
}

