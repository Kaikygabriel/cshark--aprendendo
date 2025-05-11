using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Alocacao2.Entity;

namespace Alocacao2.Service
{
    internal class RentalService
    {
        public RentalService() { }

        public RentalService(double priceHours, double priceDays,ITaxService service)
        {
            PriceHours = priceHours;
            PriceDays = priceDays;
            _taxa = service;
        }

        public double PriceHours { get; private set; }
        public double PriceDays{ get; private set; }
        private ITaxService _taxa;
        public void ValorTotal(CarRental carRental)
        {
            TimeSpan duracao = carRental.Entregua.Subtract(carRental.Entrada);
            
            double TotalBasico = 0;
            if(duracao.Hours <= 12)
            {
                double aredonda = Math.Ceiling(duracao.TotalHours);
                TotalBasico = aredonda * PriceHours;
            }
            else
            {
                double aredonda = Math.Ceiling(duracao.TotalDays);
                TotalBasico = aredonda * PriceDays;
            }
            double taxa = _taxa.Tax(TotalBasico);
            carRental.Invoice = new Invoice(TotalBasico, taxa);
        }
    }
}
