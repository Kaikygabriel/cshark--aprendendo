using System;
using CriarContratos.Entities;

namespace CriarContratos.Service.Interfaces
{
    internal interface IServiceParcela
    {
        public void GerarParcela(Contrato contrato, int numParcela);
    }
}
