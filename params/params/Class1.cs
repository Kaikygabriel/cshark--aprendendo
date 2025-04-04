using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paramsa
{
    internal class Calculadora
    {
        public static void Adicionar(params List<int> list)//params indica que a função pode receber uma quantia variada de valores
        {
            int soma = 0;
            foreach (int i in list)
            {
                soma += i;
            }
            Console.WriteLine(soma);
        }
        public static void tripicar(ref int x)
        {
            x = x * 3;
        }
        public static void Criar(int original,out int modificar)
        {
            modificar = original * 3;
        }
    }
}
