using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion12
{
    internal class FlightBooking
    {
        //Properties
        public string PassengerName { get; set; }
        public int FlightNumber { get; set; }
        public int SeatNumber { get; set; }
        private string CreditCardInfo { get; set; }



        //Constructor

        //Methods
        public void DisplayBookingDetails()
        {
            Console.WriteLine($"Passenger {PassengerName} - Flight number {FlightNumber} and seat number {SeatNumber}.");
        }

        public void ProcessPayment(string creditCard)
        {

            CreditCardInfo = creditCard;
            Console.WriteLine("Payment successful.");


        }

    }

    //    Övning: Skapa en FlightBooking-klass
    //1. Skapa en klass som heter FlightBooking.
    //2. public fält:
    //○ PassengerName: Passagerarens namn.
    //○ FlightNumber: Flygnumret.
    //○ SeatNumber: Platstilldelning.
    //3. private fält:
    //○ CreditCardInfo: Betalningsinformation(skyddad).
    //4. Skapa en metod DisplayBookingDetails som visar passagerarens namn, flygnummer och platsnummer.
    //5. Skapa en metod ProcessPayment som tar in betalningsuppgifter och behandlar betalningen, men låter inte externa klasser få
    //direkt åtkomst till kreditkortsinformationen.
}
