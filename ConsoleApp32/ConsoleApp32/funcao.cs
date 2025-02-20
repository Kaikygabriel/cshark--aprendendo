using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp32
{
    abstract class funcao
    {
        //classe abastrata
        //ela vai se comportar como fosse uma interface ou seja não pode criar uma instancia para um objeto
        //abstract indica que é uma classe abstrata
        //tem que colocar o public, e colocar abstract para funcionar.
        public abstract  void exibir();
        public  string nome;
        //pode colocar variaveis ao contrario das interface
        //apenas pode colocar 1 classe abstrata por vez na classe (funciona como herança)
    }
    class circulo : funcao
    {   
        public override void exibir()
        {
       
          // tem que colocar override na função
          //ela faz tambem relaçao de herança (nome)
        }
    }
}
