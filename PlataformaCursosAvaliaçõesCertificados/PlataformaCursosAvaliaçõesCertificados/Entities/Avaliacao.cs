using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace PlataformaCursosAvaliaçõesCertificados.Entities
{
    internal sealed class Avaliacao
    {
        public Avaliacao() { }
        public Avaliacao(int nota)
        {
            Nota = nota;
        }
        public int Nota { get; private set; }
    }
}
