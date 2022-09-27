
using Tmac.Entities.Exceptions;

namespace Tmac.Entities
{
    internal class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime Checkin { get; set; }
        public DateTime Chekout { get; set; }

        public Reservation() { }

        public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut)
        {
            if (checkOut <= checkIn)
            {
                throw new DomainException("Erro: O check-out deve ser reservado em datas futuras!");
            }

            Checkin = checkIn;
            Chekout = checkOut;

            RoomNumber = roomNumber;
            Checkin = checkIn;
            Chekout = checkOut;
        }

        public int Duration()
        {
            TimeSpan duration = Chekout.Subtract(Checkin);
            return (int)duration.TotalDays;
        }

        public void UpdateDates(DateTime checkIn, DateTime checkOut)
        {
            DateTime now = DateTime.Now;
            if( checkOut < now || checkIn < now )
            {
                Console.WriteLine();
                throw new DomainException("                Erro: O check-out deve ser reservado em datas futuras!");
                
                
            }
            if(checkOut <= checkIn)
            {
                Console.WriteLine();
                throw new DomainException("                Erro: O check-out deve ser reservado em datas futuras!");
            }

            Checkin = checkIn;
            Chekout = checkOut;
        }

        public override string ToString()
        {
            Console.WriteLine("           =+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=");
            Console.WriteLine($"                           Quarto: {RoomNumber}");
            Console.WriteLine($"            Check-in: {Checkin.ToString("dd/MM/yyyy")} || Check-out: {Chekout.ToString("dd/MM/yyyy")}");
            Console.WriteLine($"                           Duração de {Duration()} noites");
            return "           =+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=";
        }
    }
}
