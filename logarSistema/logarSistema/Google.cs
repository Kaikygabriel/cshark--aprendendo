using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logarSistema
{
    [System.Serializable]
    internal class Google : Usuario
    {
        
        public string email;
        public Google(string nome,int senha,string email) : base(senha, nome) 
        {
            this.email = email;
        }
    }
}
