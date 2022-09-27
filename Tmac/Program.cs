using Tmac.Entities;

using Tmac.Entities.Exceptions;

namespace Tmac
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {

                Console.WriteLine();
                Console.WriteLine("              !>>> HOTEL CALIFÓRNIA <<<!");
                Console.WriteLine();
                Console.WriteLine("                  reserva de quartos");
                Console.WriteLine();
                Console.WriteLine();

                Console.Write("                 Digite o numero do quarto: ");
                int roomNumber = int.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.Write($"                Data check-in: ");
                DateTime checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write($"                Data check-out: ");
                DateTime checkOut = DateTime.Parse(Console.ReadLine());

                Reservation reservation = new(roomNumber, checkIn, checkOut);

                Console.WriteLine();
                Console.WriteLine(reservation);

                Console.WriteLine();
                Console.WriteLine("                Entre com a data de ");
                Console.Write("                atualização da reserva: ");
                checkIn = DateTime.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("                Agora entre com");
                Console.Write("                a data de check-Out: ");
                checkOut = DateTime.Parse(Console.ReadLine());

                reservation.UpdateDates(checkIn, checkOut);

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("                >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
                Console.WriteLine($"                 Dados atualizados para o quarto: {roomNumber}");
                Console.WriteLine("                >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
                Console.WriteLine(reservation);
            }
            catch (DomainException e)
            {
                Console.WriteLine($"{e.Message}");
            }
        }
    }
}
