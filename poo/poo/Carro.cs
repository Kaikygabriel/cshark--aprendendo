using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo
{
    internal class Carro
    {
        public string nome;
        public string marca;
        public string motor;
        public float preco;
        public int porta;
        public int ano;
        public Carro(string nome, string marca, string motor, float preco, int porta, int ano)
        {
            this.nome = nome;
            this.marca = marca;
            this.motor = motor;
            this.preco = preco;
            this.porta = porta;
            this.ano = ano;
            exibir();
        }
        public void exibir() 
        {
            Console.WriteLine($"O carro {this.nome}, tem a marca{marca}, eo preço de R${this.preco}, com o ano de {ano}");
        }
        public void buzina1()
        {
            Console.WriteLine("bibi");
        }
        public static void buzina()
        {
            //campos estaticos so podem ser acessados pela classe = carro.
            //campos não estaticos so podem ser acessados por objetos da classe = carro fun = new carro();m 
            //quando define algo como static ela apenas pertence a classe não aos objetos dela(copias)
            //dentro de um metodo statico não posso acessar as instancias das classes
            //so consigo trabalhar com variaveis staticas dentro dos metodos staticos
            Console.WriteLine("bibi");
        }
    }
}
