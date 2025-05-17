using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerarRelatorio.Service
{
    internal sealed class RelatorioPDF : IRealatorio
    {
        private string _path = @"C:\Users\kaiky\Downloads\Relatorio\Relatorio1.pdf";
        public void Gerar(string Menssage)
        {
            if (Menssage.Length <= 0)
             throw new Exception("O relatorio precisa ter alguma menssagem");

            using (StreamWriter sw = File.AppendText(_path))
            {
                sw.WriteLine(Menssage);  
            }
        }
    }
}
