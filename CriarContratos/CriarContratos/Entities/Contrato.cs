using System;
using System.Reflection.Metadata.Ecma335;

namespace CriarContratos.Entities
{
    internal class Contrato
    {
        public Contrato() { }

        public Contrato(DateTime data, double totalPrice)
        {
            Data = data;
            TotalPrice = totalPrice;
        }

        public string Id { get; private set; }= Guid.NewGuid().ToString()[..5];
        public DateTime Data { get; private set; }
        public double TotalPrice { get; private set; }
        public List<Parcelas>Parcelas { get; set; }= new List<Parcelas>();
    }
}
