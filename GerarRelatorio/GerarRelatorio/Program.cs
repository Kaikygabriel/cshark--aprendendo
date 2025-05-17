using System;
using GerarRelatorio.Model;
using GerarRelatorio.Service;

namespace GerarRelatorio
{
    internal class Program
    {
        static void Main()
        {
            Relatorio relatorio = new Relatorio(new RelatorioPDF());
            Relatorio relatorio1 = new Relatorio(new RelatorioCsv());

            relatorio.Executar("OLa mundo PDF");
            relatorio1.Executar("Ola mundo CSV");
        }
    }
}
