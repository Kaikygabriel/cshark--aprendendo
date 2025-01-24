using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace AprendendoStructs
{

  internal class Program
    {
        struct produtos
        {
            //structs são como voce tivesse colocando variavel dentro de variavel
            public string nome;
            public float preco;
            public float taxa;
            public string marca;
        }
        struct inimigo
        {
        //palavra reservada // definir um nome pra sua variavel(produtos)
            public string nome;
            public int vida;
            public int forca;
        }
        static void Main()
        {
            produtos roupa1 = new produtos();
            roupa1.marca = "nike";
            roupa1.nome = "camisa";
            roupa1.preco = 20f;
            Console.WriteLine( roupa1.marca);

            produtos roupa2 = new produtos();
            roupa2.nome = "camisa";
            roupa2.marca = "puma";
            roupa2.preco = 18f;
            Console.WriteLine( roupa2.marca);

            inimigo inimigo1 = new inimigo();
            inimigo1.nome = "goodofwor";
            inimigo1.forca = 20;
            inimigo1.vida = 100;
            Console.WriteLine(inimigo1.vida);

            Console.ReadLine();
        }

    }
}
