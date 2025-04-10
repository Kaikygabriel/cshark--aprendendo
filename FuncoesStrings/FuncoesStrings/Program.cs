namespace FuncoesStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string e uma variavel tipo referencia, quando mudamos o valor da string não alteramos o valor , apenas damos um novo endereço para apontar
            string original = "Ola mundo Kaiky Gabriel";
            Console.WriteLine(original);    
            string Maiusculo = original.ToUpper();// transforma toda as palavras em maiusculo
            Console.WriteLine(Maiusculo);
            string s2 = original.ToLower(); // transforma em minusculo
            Console.WriteLine(s2);
            string s3 = original.Trim(); // apaga os espaço em branco tanto da frente enquanto o de tras
            Console.WriteLine(s3);
            int n1 = original.IndexOf("mu");//Proucura o index de uma ocorrencia(palavra chave ou letra) ,  A PRIMEIRA  
            Console.WriteLine(n1);
            int n2 = original.LastIndexOf("a");// que nem o indexOf porem proucura a ultima ocorrencia
            Console.WriteLine(n2);
            string s4 = original.Substring(3);//vai cortar os 3 primeiro caracter
            string s5 = original.Substring(3,5); //vai pegar os caracter apenas do 3 ate o 5
            string s6 = original.Replace('a', 'k');//troca toda letra a pelo k
            Console.WriteLine(s6);
        }
    }
}
