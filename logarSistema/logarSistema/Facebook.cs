using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logarSistema
{
    [System.Serializable]
    internal class Facebook : Usuario
    {
        public Facebook(string nome, int senha):base(senha,nome) { }
    }
}
