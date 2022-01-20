using System;
using ReservaTryCatch.Entities.Exceptions;

namespace ReservaTryCatch.Entities
{
    class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reservation()
        {

        }

        public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut)
        {
            if (checkOut <= checkIn)
            {
                throw new DomainException("Errroooo Doamin");
            }
            RoomNumber = roomNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }


        public int Duration()
        {
            TimeSpan duration = CheckOut.Subtract(CheckIn);

            return (int)duration.TotalDays;
        }

        public void UpdateDates(DateTime checkIn, DateTime checkOut)
        {
            DateTime now = DateTime.Now;

            if (checkIn < now || checkOut < now)
            {
                throw new DomainException("Errroooo Doamin");
            }
            else if (checkOut <= checkIn)
            {
                throw new DomainException("Outro errroooo Doamin");
            }

            CheckIn = checkIn;
            CheckOut = checkOut;
        }



        public override string ToString()
        {
            return "Room "
                + RoomNumber
                + ", Check-in: "
                + CheckIn.ToString("dd/MM/yyyy")
                + ", Check-OUT: "
                + CheckOut.ToString("dd/MM/yyyy")
                +", Duration: "
                + Duration()
                +" nights";
        }
    }
}
