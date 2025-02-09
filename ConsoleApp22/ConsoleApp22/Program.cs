using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Permissions;

namespace ConsoleApp22
{
    struct produtos
    {
        public float preco;
        public string nome;
        public produtos(float preco, string nome)
        {
            this.preco = preco;
            this.nome = nome;
            exibir();
        }
        public void exibir()
        {
            Console.WriteLine($"o item {this.nome} tem o preço R${this.preco}");
            Console.WriteLine("");
        }
    }



    internal class Program
    {
        static List<string> carrinhoNome = new List<string>();
        static List<float> carrinhoPreco = new List<float>();
        enum item {banana = 1,bola,roupa }
        enum op {add = 1,ver,sair}
        static void Main()
        {
            bool sair = false;
            while (!sair)
            {
                Console.WriteLine("COMPRAS ESCOLHA UMA DAS OPÇÂO ABAIXO \n 1-adicionar item \n2-carrinho\n3-sair");
                op sele = (op)int.Parse(Console.ReadLine());
                switch (sele) 
                {
                    case op.add:
                        Console.Clear();
                        adicionar();
                        break;
                    case op.sair:
                        sair = true;
                        break;
                    case op.ver:
                        Console.Clear();
                        ler();
                        break;
                    default:
                        Console.WriteLine("error numero não encontrado");
                        break;
                }
                Console.Clear();
            }
        }
        static void adicionar()
        {
            Console.WriteLine("escolha um item \n1- banana \n2- bola \n3 roupa");
            produtos banana = new produtos(2.4f, "banana");
            produtos bola = new produtos(22f, "bola");
            produtos roupa = new produtos(30f, "roupa-nike");
            item escolha = (item)int.Parse(Console.ReadLine());
            switch (escolha)
            {
                case item.bola:
                    carrinhoNome.Add(bola.nome);
                    carrinhoPreco.Add(bola.preco);
                    break;
                case item.banana:
                    carrinhoNome.Add(banana.nome);
                    carrinhoPreco.Add(banana.preco);
                    break;
                case item.roupa:
                    carrinhoNome.Add(roupa.nome);
                    carrinhoPreco.Add(roupa.preco);
                    break;
                default:
                    Console.WriteLine("error numero não encontrado");
                    break;
            }
            FileStream enviar = new FileStream("compra.txt", FileMode.OpenOrCreate);
            FileStream enviarpreco = new FileStream("compra-preco.txt", FileMode.OpenOrCreate);
            BinaryFormatter converter = new BinaryFormatter();
            converter.Serialize(enviar, carrinhoNome);
            converter.Serialize(enviarpreco, carrinhoPreco);
            enviar.Close();
            enviarpreco.Close();
            Console.WriteLine("item adicionado");
        }
        static void ler()
        {
            if (File.Exists("compra.txt") && File.Exists("compra-preco.txt"))
            {
                Console.WriteLine("items no carrinho");
                FileStream enviar = new FileStream("compra.txt", FileMode.OpenOrCreate);
                FileStream enviarpreco = new FileStream("compra-preco.txt", FileMode.OpenOrCreate);
                BinaryFormatter converter = new BinaryFormatter();
                List<string> nomeitems = (List<string>)converter.Deserialize(enviar);
                List<float> preco = (List<float>)converter.Deserialize(enviarpreco);
                enviar.Close();
                enviarpreco.Close();
                //lendo o nome dos produtos
                foreach (string item in nomeitems)
                {
                    Console.WriteLine(item);
                }
                //preço dos produtos
                foreach (float p in preco)
                {
                    Console.WriteLine($"R${p}");
                }
                Console.ReadLine();


            }
            else
            {
                Console.WriteLine("nada no carrinho");

                Console.ReadLine();
            }
        }

        
        
    }
}
