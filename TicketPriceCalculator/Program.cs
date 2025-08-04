using System;

namespace TicketPriceCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Movie Theater Ticket Price Calculator");
            Console.WriteLine("-------------------------------------");
            
            Console.Write("Enter your age: ");
            if (int.TryParse(Console.ReadLine(), out int age))
            {
                decimal ticketPrice = CalculateTicketPrice(age);
                Console.WriteLine($"Your ticket price is: GHC {ticketPrice}");
            }
            else
            {
                Console.WriteLine("Invalid input! Please enter a valid age.");
            }
        }

        static decimal CalculateTicketPrice(int age)
        {
            // Regular price
            decimal regularPrice = 10.00m;
            
            // Check for discount eligibility
            if (age <= 12 || age >= 65)
            {
                return 7.00m; // Discounted price
            }
            
            return regularPrice;
        }
    }
}
