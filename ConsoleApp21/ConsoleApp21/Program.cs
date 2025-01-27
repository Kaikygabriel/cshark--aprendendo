using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    //indica que o tipo de dado produto pode ser salvo em arquivo binario
    [System.Serializable]
    struct produto
    {
        public int preco;
        public string nome;
        public produto(int preco,string nome)
        {
            this.preco = preco;
            this.nome = nome;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            produto bola = new produto(2, "bola");
            List<string> nome2 = new List<string>() {"gabriel","gustavo"};
            string nome = "kaiky gabriel";
            int idade = 16;
            FileStream streambin = new FileStream("teste.txt", FileMode.OpenOrCreate);
            //filestream serve para leitura e para escrita
            //fileMode  == de que modo que trabalhar com esse arquivo, OpenOrCreate =abrir e criar arquivo 
            //serializador ele pega oque voce criar(string int etc) e converte para tipos de dados binario(bits)
            BinaryFormatter formatter = new BinaryFormatter();
            //arquivos binarios tem o poder de salvamento de listas 
            //ele vai converter os dados que eu colocar
            formatter.Serialize(streambin, 12);
            // chama o binary depois o serialize, chama a stream, e depois coloca o dado que quiser(int string bool)
            formatter.Serialize(streambin, "kaiky");
            formatter.Serialize(streambin,true);
            formatter.Serialize(streambin, nome);
            formatter.Serialize(streambin, idade);
            formatter.Serialize(streambin, nome2);
            //pode ser salvo tambem structs ou variaveis especiais
            formatter.Serialize(streambin, bola);
            streambin.Close();
        }
    }
}
