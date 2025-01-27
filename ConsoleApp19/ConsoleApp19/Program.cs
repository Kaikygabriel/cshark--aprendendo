using System.IO;
using System.Globalization;
namespace ConsoleApp19
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Gerando arquivo");
            //StreamWriter escrever = File.AppendText("clientes.txt");
            //escrever.WriteLine("kaiky");
            //escrever.WriteLine("Gabriel");
            //escrever.Close();

            StreamReader leitor = new StreamReader("clientes.txt");
            //string conteudo = leitor.ReadToEnd();//ele vai ler todo o arquivo, e salvar todo o conteudo do arquivo numa unica string
            ////todo texto ta salvo em uma unica variavel


            //toda vez que chamar ele, vai exibir uma linha do arquivo(1- kaiky,2-gabriel etc...),se mandar ele ler mais linha que tem no arquivo ele vai exibir null
            string linha = "";
            List<string> linhas = new List<string>();    
            while (linha != null) 
            {
                linha = leitor.ReadLine();
                if(linha != null)
                {
                  linhas.Add(linha);
                }

            }

            foreach (string line in linhas) 
            {
                Console.WriteLine(line);
            }
            leitor.Close();
            //tem que fechar o leitor tambem
            Console.ReadLine();
        }
    }
}
