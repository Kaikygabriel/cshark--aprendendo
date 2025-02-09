using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
    internal class Usuario
    {
        protected string nome;
        public string email;
        public Usuario( string nome, string email)
        {     
                this.nome = nome;
                this.email = email;
        }
        //se o campo e privado não importa se tem herança so vai poder acessar atraves da class que o elemento estiver
        //PROTECED -- e que nem o private porem, na herança pode acessar, tanto a class pai quanto a class filho
        //logar(void)
        public void exibir()
        {
            Console.WriteLine("Logando");
        }
        //pode se criar um metodo com o mesmo nome (polimorfismo sobrecarga)
        //porem so pode se os parametros forem diferentes, não inporta o nome do parametro so o tipo deles ea ordem deles
        //ter multiplas versoes de um metodo
        //assinatura do metodo (nome dele , eo que esta dentro dele (parametros))
        //logar (string)
        //ex como usar, voce pode ter varias maneiras de logar 
        //ter multiplas versão de um metodo
        public void exibir(string nome)
        {
            Console.WriteLine("Logando " + nome);
        }
        public void exibir(string email,string senha)
        {
            Console.WriteLine(email, senha);
        }
    }
}
