using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;//modulo que,tira informação do seu programa(permite que gere arquivio, e le informção para dentro do programa)(INPUT OUTPUT)

namespace ConsoleApp17
{
    internal class Program
    {
        static void Main()
        {
            StreamWriter escritor2 = File.AppendText("teste2.txt");// novo tipo de stream, ele vai criar um tipo de stream especializada em adicionar arquivos
                                                                   //sem remover as interiores

            escritor2.WriteLine("KAIKY");
            escritor2.Close();




            List<string> lista = new List<string>() {"minecraft","gta","roblox","csgo"};

            StreamWriter escritor = new StreamWriter("teste.txt"); // não importa a extensão do arquivo(.txt, .html ,etc) o que define se e um arquivo de texto, ou binario é o conteudo que ta dentro dele
            //caso o arquivo não exista, o csharp cria o arquivo
            // com o fluxo criado pode enviar as informação que quiser para o arquivo
            escritor.WriteLine("OLá Mundo!");
            escritor.WriteLine("kaiky");
            escritor.WriteLine("WROOO");
            string sobrenome = "gabriel";
            lista.RemoveAt(0);
            foreach (string s in lista)
            {
                escritor.WriteLine(s);
            }
          
            escritor.WriteLine(sobrenome);
            //tem que fechar o fluxo de comunição assim que acabar de usar
            // se não fechar oque voce colocou não vai ir para o arquivo
            //se não fechar o arquivo pode ficar aberto, eos outros programa que precisam desse arquivo não consigam
            escritor.Close();
            //close fecha o fluxo
            Console.Write("arquivo gerado");
            Console.ReadLine();
        }
    }
}
