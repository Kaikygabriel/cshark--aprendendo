using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaDeLogs.Entity;

namespace SistemaDeLogs.Service
{
    internal class ServiceUsuario
    {
        private ILogger _logger;
        public void AdicionarUsuario(string nome,ILogger maneira,Usuario usuario)
        {
            _logger = maneira;
            usuario = new Usuario(nome);
            _logger.Log(nome);
        }
    }
}
