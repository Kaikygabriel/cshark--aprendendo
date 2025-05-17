using System;
using GerarRelatorio.Service;

namespace GerarRelatorio.Model
{
    internal sealed class Relatorio
    {
        public Relatorio() { }

        public Relatorio(IRealatorio realatorio)
        {
            _realatorio = realatorio;
        }

        private IRealatorio _realatorio;
        public void Executar(string menssage)
        {
            _realatorio.Gerar(menssage);
        }
    }
}
