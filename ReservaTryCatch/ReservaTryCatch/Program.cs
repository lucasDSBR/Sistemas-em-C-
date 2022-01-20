using System;
using ReservaTryCatch.Entities;


namespace ReservaTryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Room number: ");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("Check-in date (DD/MM/YYYY): ");
            DateTime checkIn = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Check-out date (DD/MM/YYYY): ");
            DateTime checkOut = DateTime.Parse(Console.ReadLine());

            if(checkOut <= checkIn)
            {
                Console.WriteLine("Erro entre valores de datas.");
            }
            else
            {
                Reservation reservation = new Reservation(number, checkIn, checkOut);
                Console.WriteLine("Resevation: "+reservation);


                Console.WriteLine("Atualizar datas de reservas: ");
                Console.WriteLine("Check-in date (DD/MM/YYYY): ");
                checkIn = DateTime.Parse(Console.ReadLine());

                Console.WriteLine("Check-out date (DD/MM/YYYY): ");
                checkOut = DateTime.Parse(Console.ReadLine());
                
                
                reservation.UpdateDates(checkIn, checkOut);
                Console.WriteLine("Resevation: " + reservation);
                


            }
            
        }
    }
}
