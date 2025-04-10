namespace Blibioteca
{
    internal class Program
    {
        public static List<Blibioteca>listb = new List<Blibioteca>();  
        static void Main()
        {

            bool sair = true;
            while (sair)
            {
                Console.WriteLine("1- Adicionar Blibioteca \n2-adicionar livros a blibioteca\n 3 -ver livros blibiotecas \n 4 sair");
                int sele = int.Parse(Console.ReadLine().Trim());
                switch (sele)
                {
                    case 1:
                        Blibioteca.AddBlibioteca();
                        break;
                    case 2:
                        AbrirBlibioteca();
                        break;
                    case 3:
                        VerLivroBlibioteca();
                        break;
                    case 4:
                        sair = false;
                        break;
                    default:
                        Console.WriteLine("ERROR");
                        Console.Clear();
                        Main(); 
                        break;
                }
                Console.Clear();
            }
          
        }
        static void AbrirBlibioteca()
        {
            try
            {
                if (listb.Count > 0)
                {
                    foreach (Blibioteca b in listb)
                    {
                        Console.WriteLine($"A blibiotecas {b.Nome} estão adicionadas");
                    }
                    Console.WriteLine("Nome da blibioteca");
                    string nome = Console.ReadLine().Trim();
                    foreach (Blibioteca b in listb)
                    {
                        if (nome.Equals(b.Nome, StringComparison.CurrentCultureIgnoreCase))
                        {
                            b.AdicionarLivro();
                        }
                    }
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Não tem nada");

                }
            }
            catch(Exception e)
            {
                Console.Clear();
                Main();
            }
            
        }
        static void VerLivroBlibioteca()
        {
             if(listb.Count > 0)
            {
                foreach (Blibioteca b in listb)
                {
                    Console.WriteLine($"A blibioteca {b.Nome} tem o livros ");
                    b.ExibirLivros();
                    Console.WriteLine("===================================");
                }
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Não tem nada");
            }
        }
    }
}
