using System;
using System.Globalization;
using locatora.Entities;
using locatora.Entities.Services;
namespace locatora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter rental data");
            Console.WriteLine("Car model: ");
            string model = Console.ReadLine();
            Console.WriteLine("Pickup (dd/MM/yyyy hh:ss): ");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            Console.WriteLine("Return (dd/MM/yyyy hh:ss): ");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            Console.WriteLine("Enter price per hour: ");
            double hour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Enter price per day: ");
            double day = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            CarRental carRental = new CarRental(start, finish, new Vehicle(model));


            RentalServices rentalServices = new RentalServices(hour, day, new BrasilTextServices);


            rentalServices.ProcessInvoide(carRental);

            Console.WriteLine("INVOICE:");

            Console.WriteLine(carRental.Invoice);
        }
    }
}
