using System;
using CriarContratos.Entities;
using CriarContratos.Service;

namespace CriarContratos
{
    internal class Program
    {
        static void Main()
        {
            DateTime data = DateTime.Now;
            double valor = 600;
            Contrato contrato = new Contrato(data,valor);
            ServiceParcela service = new ServiceParcela();
            service.GerarParcela(contrato,3);
            contrato.Parcelas.GetList<Parcelas>();
        }
    }
}
