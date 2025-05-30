using System;
using System.Text;
using System.Linq;
using System.Threading.Channels;

namespace Linq
{
    internal class Teste
    {
        public static void teste()
        {
            int[] vect = { 1, 2, 3, 4, 5, 6 };

            //1 elemento da lista
            Console.WriteLine(vect.First());
            Console.WriteLine(vect.FirstOrDefault());//caso não conseguir pegar um valor retorna um tipo generico relativo ao tipo da lista
                 
            //verificar se existe na lista
            Console.WriteLine(vect.Any(x => x == 1));//true ou false

            //verifica se todos os elementos atendem a uma condição
            Console.WriteLine(vect.All(x => x % 2 ==0 ));

            //contar elementos da lista
            Console.WriteLine(vect.Count());
            Console.WriteLine(vect.Count(x => x %2 ==0));

            //pega elemento pelo index 
            Console.WriteLine(vect.ElementAt(5));

            //take --cria uma nova lista de acordo com o range de um determinado index
            var list = vect.Take(1..3).ToList();

            //Where - cria um nova lista- agi como uma condição
            var impar = vect.Where(x => x % 2 != 0).ToList();

            //Single - pega somente um elemento,se tiver mais de um vai ocorrer erro
            var a = vect.Single(x => x == 1);
            Console.WriteLine(a);
        }
    }
}

        