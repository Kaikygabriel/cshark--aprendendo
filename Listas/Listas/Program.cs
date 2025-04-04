namespace Listas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>() {"Kaiky","gabriel","Alves"};
            list.Insert(0, "Kg");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(list.Count);
            //predicado é uma função que pega um valor e retorna verdadeiro ou falso conforme a logica que estiver nessa função
            //expressão lambida
            //parametro da função (x )e uma condição que se caso x tiver mais que 5 caracter, s se torna esse x
            string s = list.Find(x => x.Length >= 5);
            Console.WriteLine(s);
            //vai guardar todos os elementos que  tiver mais  que 4 caracter, s se torna esse x
            List<string> list2 = list.FindAll(x => x.Length >= 4);
        }
    }
}

                

        