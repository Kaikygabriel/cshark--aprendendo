using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeLogs.Service
{
    internal sealed class ConsoleLogger : ILogger
    {
        public List<string> loggers { get; private set; } = new List<string>();
        public void Log(string message)
        {
            loggers.Add(message);
        }
    }
}
