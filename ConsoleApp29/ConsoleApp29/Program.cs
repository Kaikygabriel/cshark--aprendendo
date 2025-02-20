using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp29
{
    
    internal class Program
    {
        //tem como criar variaveis usando interface
        static void Main(string[] args)
        {
            Idesenhar colocar = new bola();
            //não da pra instancia a interface, tem que ser as class que usa interface
            colocar.desenho();
        }

    }
    // palavra chave - nome(padrão começar com um I maisuculo não é obrigatorio)
    //contrato
    interface Idesenhar
    {
        //quando tem uma interface nao trabalha com modificador de acesso, tudo é publico
        void desenho();//não pode definir logica dentro, apenas a anotação dele(retorno dele o nome dele eos parametros)
        string cor();
        float area();
    }
    //que nem herança (:), indica que linha segue o contrato com Idesenhar,da pra colocar herança junto,apenas dividir por uma virgula
    //pode ter quantas interface que quiser, ao contrario de herança
    //a interface so define um conjunto de metodos que a classe tem que implementar
    //quando coloca uma interface numa class e obrigado a inplementar os metodos que a interface manda
    //garantir que dentro de uma classe vai ter um conjunto de metodos
    internal class linha : Idesenhar
    {
        public float area()
        {
            return 20f;
        }

        public string cor()
        {
            return "azul";
        }

        public void desenho()
        {
            Console.WriteLine("Desenhou");
        }
    }
    internal class quadrado : Idesenhar
    {
        public float area()
        {
            return 50f;
        }

        public string cor()
        {
            return "verde";
        }

        public void desenho()
        {
            Console.WriteLine("bola");
        }
    }
    internal class bola : Idesenhar
    {
        public float area()
        {
            return 10f;
        }

        public string cor()
        {
            return "amarelo";
        }

        public void desenho()
        {
            Console.WriteLine("quadrado");
        }
    }

}
