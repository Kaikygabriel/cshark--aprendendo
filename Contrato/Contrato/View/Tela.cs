using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contrato.Controler;

namespace Contrato.View
{
    internal class Tela
    {
        public static void TelaInicial()
        {
            Funcao.AdicionarUsuario();
            Funcao.AdicionarContrato();
            Funcao.Total();
        }
    }
}
