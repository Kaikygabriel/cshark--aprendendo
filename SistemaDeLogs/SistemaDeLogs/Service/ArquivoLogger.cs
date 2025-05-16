using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeLogs.Service
{
    internal sealed class ArquivoLogger : ILogger
    {
        public string Caminho { get; set; } = @"C:\Users\kaiky\Downloads\kaka\users.txt";
        public void Log(string message)
        {
            using (StreamWriter sw = File.AppendText(Caminho))
            {
                sw.WriteLine(message);
            }
        }
    }
}
