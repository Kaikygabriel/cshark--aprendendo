using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsandoConstructor
{
    internal class Program
    {
        struct Produto
        {
            public float preco;
            public string nome;
            public string marca;
            
            //função constructor , não retorna nada, não precisa colocar o void (ja e automatico ser sem retorno), e precisa ter o mesmo nome da struct que ele esta
            public Produto(float preco ,string nome, string marca )
            {
                //this to acessando um atributo do struct do produto
                //obrigatoriamente tem que definir os valores de todos os campos do construtor(preco, nome ,marca)
                this.preco = preco;// variavel do atributo = (recebe) variavel do parametro
                this.nome = nome;
                this.marca = marca;
                  
            }
            //primeiro o public depois define o tipo de retorno, depois o nome
            public void exibirInfo()
            {
               
                Console.WriteLine($"Nome é {this.nome}");
                Console.WriteLine($"O preço é {this.preco}");
                Console.WriteLine($"A marca é {this.marca}");
            }

            public void addcupom(float por)
            {
                float desconto = (this.preco * por )/ 100f;
                this.preco = Math.Abs(desconto - this.preco); 
            }
            public void teste()
            {
                Console.WriteLine("TESTE");
            }
        }
        static void Main()
        {
            Produto bola = new Produto(12,"bola do ney","nike");
            bola.exibirInfo();

            Console.WriteLine("-----------------");

            Produto roupa = new Produto(20, "Camisa", "puma");
            roupa.exibirInfo();
            Console.WriteLine("-----------------");

            Produto roupa2 = new Produto(100, "regata", "adidas");
            roupa2.addcupom(100f);
            roupa2.exibirInfo();

            Console.ReadLine();
        }
    }
}
