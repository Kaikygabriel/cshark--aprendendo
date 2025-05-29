using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CriarContratos.Entities;
using CriarContratos.Service.Interfaces;

namespace CriarContratos.Service
{
    internal class ServiceParcela : IServiceParcela
    {
        public void GerarParcela(Contrato contrato,int numParcela)
        {
            double totalPrice = contrato.TotalPrice;
            double valorMensal= totalPrice/numParcela;
            for (int i = 1; i <= numParcela; i++)
            {
                DateTime dataParcela = contrato.Data.AddMonths(i);
                double primeiro = valorMensal + (valorMensal * (0.01 * i));
                double segundo = primeiro + (primeiro* 0.02);
                contrato.Parcelas.Add(new Parcelas(segundo, dataParcela));
            }
        }
    }
}

