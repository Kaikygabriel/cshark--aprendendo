namespace DesafiosTempo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Receber();
        }
        static void Receber()
        {
             DateTime anoNascimento = new DateTime(2008,03,16);
            DateTime agora = DateTime.Now;
            int idade = agora.Year -  anoNascimento.Year ;
            
            Console.WriteLine(idade);
        }
    }
}
