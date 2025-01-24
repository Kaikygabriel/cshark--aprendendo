using System.Globalization;

namespace ConsoleApp16
{   
    
    struct Produto
    {
        public string nome;
        public float valor;
        public float imposto;
        public Produto(string nome, float valor, float imposto)
        {
            this.nome = nome;
            this.valor =valor;
            this.imposto = ((this.valor * imposto) /100)+this.valor;
            exibir();
        }
        public void exibir()
        {
            Console.WriteLine("");
            Console.WriteLine($"O Produto {this.nome}\n tem o valor R${this.valor} \n Mais com imposto tem o valor de R${this.imposto}");
        }
    }
    //-----------------------------------------------------------------
   internal class Program
    {
        enum opcao {ver = 1,sair,carro}
        static void Main()
        {
            bool sair = false;
            while (!sair) 
            {
                Console.WriteLine("Escolha uma das opção abaixo\n 1-ver produto\n 2-sair \n 3-ver carrinho");
                opcao OpcaoSele = (opcao)int.Parse(Console.ReadLine());
                switch (OpcaoSele)
                {
                    case opcao.sair:
                        sair = true;
                        break;
                    case opcao.ver:
                        Console.Clear();
                        loja.mostrar();
                        break;
                    case opcao.carro:
                        carrinho();
                        break;
                    default:
                        Console.WriteLine("ERROR");
                        break;
                }
                Console.Clear();
            }
        }
        static void carrinho()
        {
            if(loja.carinho.Count > 0)
            {
                foreach(string carro in loja.carinho)
                {                
                        Console.WriteLine($"produto {carro}  , no carrinho");
                
                }
                foreach (float carinho in loja.carinhoPreco)
                {
                    Console.WriteLine($"produto custa R${carinho}");
                   
                }
                Console.ReadLine();
            }
            else
            {
                
                Console.WriteLine("nenhum produto adicionado");
                Console.ReadLine();
            }
        }
    }
//-------------------------------------------------------------------------------------------
    public class loja 
    {
        public static List<string> carinho = new List<string>();
        public static List<float> carinhoPreco = new List<float>();
        public enum produtos{bola = 1,roupa,roupa2,calca }
        public static void mostrar()
        {
            Produto bola = new Produto("bola",12f,18.1f);
            Produto roupa = new Produto("camisa preta", 20f, 18.1f);
            Produto roupa2 = new Produto("camisa de time", 30f, 18.1f);
            Produto calca = new Produto("calça-dins", 50f, 18.1f);
            
            Console.WriteLine("Deseja Comprar algum produto (so pode adicionar um por vez) \n 1-bola \n 2-roupa \n 3-roupa2 \n 4-calça");
            produtos sele = (produtos)int.Parse(Console.ReadLine());
            switch (sele) 
            {
                case produtos.bola:
                    carinho.Add(bola.nome);
                    carinhoPreco.Add(bola.imposto);
                    break;
                case produtos.roupa:
                    carinho.Add(roupa.nome);
                    carinhoPreco.Add(roupa.imposto);
                    break;
                case produtos.roupa2:
                    carinho.Add(roupa2.nome);
                    carinhoPreco.Add(roupa2.imposto);
                    break;
                case produtos.calca:
                    carinho.Add(calca.nome);
                    carinhoPreco.Add(calca.imposto);
                    break;
                default:
                    break;
            }

        }
    }

}
