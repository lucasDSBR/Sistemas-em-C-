using System;
using locatora.Entities;

namespace locatora.Entities.Services
{
    class RentalServices
    {
        public double PricePerHoure { get; private set; }
        public double PricePerDay { get; private set; }


        private ITaxService _taxService;

        public RentalServices(double pricePerHoure, double pricePerDay, ITaxService taxService)
        {
            PricePerHoure = pricePerHoure;
            PricePerDay = pricePerDay;
            _taxService = taxService;
        }


        public void ProcessInvoide(CarRental carRental)
        {
            TimeSpan duration = carRental.Finish.Subtract(carRental.Start);

            double basicPayment = 0.0;

            if(duration.TotalHours <= 12.0)
            {
                basicPayment = PricePerHoure * Math.Ceiling(duration.TotalHours);
            }
            else
            {
                basicPayment = PricePerDay * Math.Ceiling(duration.TotalDays);
            }


            double tax = _taxService.Tax(basicPayment);

            carRental.Invoice = new Invoice(basicPayment, tax);
        }
    }
}
