using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerarRelatorio.Service
{
    internal class RelatorioCsv : IRealatorio
    {
        private string _path = @"C:\Users\kaiky\Downloads\Relatorio\Relatorio2.csv";
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
