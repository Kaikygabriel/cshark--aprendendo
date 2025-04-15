using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CofrinhoMoeada
{
    internal class Cofre
    {
        public string Nome;
        private float _valor;

        public Cofre(string nome, float valor)
        {
            Nome = nome;
            _valor = valor;
        }
        public void AdicionarMoeadaReal(float valor)
        {
            if(valor > 0)
            {
                _valor = valor;
                Console.WriteLine($"Voce adicionou R${valor}");
                Console.ReadLine();

            }
        }
        public void AdicionarMoeadaDolar(float valor)
        {
            if (valor > 0)
            {
               _valor = valor * 5.8f;
                Console.WriteLine($"Voce adicionou US${valor * 5.8f}");
                Console.ReadLine();
            
            }
        }
        public void calcular_total()
        {
            if (_valor > 0)
            {
                Console.WriteLine("O total é" +_valor);
            }
        }
        public void remover_moeda(float valor)
        {
            if(_valor > 0 && valor <= _valor && valor > 0)
            {
                _valor = valor - _valor;

                Console.WriteLine("O total atual é " + _valor);
            }
        }


    }
}
