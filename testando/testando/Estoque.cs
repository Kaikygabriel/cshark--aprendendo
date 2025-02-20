using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testando
{
    internal class Estoque : Produto,Interface1
    {
        public override void exibir()
        {
            Console.WriteLine("SOBREPOÇISÂO");
            base.exibir();
        }
    }
}
