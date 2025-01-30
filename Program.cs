/*
* Author: Sheetal Rana
* Date: 29 January 2025
* Project: Task_1
* Description:
* Calculate total money spent and average price of watching the game for Joe.
*/

namespace AssignmentTaskTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // initializing the variables for different colour Ticket cost
            int purpleTicketPrice = 50;
            int greenTicketPrice = 80;
            int blueTicketPrice = 100;
            // initializing variable to store number of tickets for different colour purchase and get the correct value from function GetValidNumber
            int purpleTickets = GetValidNumber("Purple");
            int greenTickets = GetValidNumber("Green");
            int blueTickets = GetValidNumber("Blue");
            int totalTickets = purpleTickets + greenTickets + blueTickets;

            // Calculate the total money spent on buying tickets
            int totalSpent = (purpleTickets * purpleTicketPrice) + (greenTickets * greenTicketPrice) + (blueTickets * blueTicketPrice);
            

            // Calculate the average price for watching game
            double averagePrice = (double)totalSpent / totalTickets;

            // Output the results
            Console.WriteLine("Total amount spent on all tickets: $" + totalSpent.ToString("C"));
            Console.WriteLine("Average price per game: $" + averagePrice.ToString("C"));
        }
        // function to validate user input for number of tickets for different colour
        static int GetValidNumber(string colour)
        {
            int numOfTicketBuy = -1;
            while (numOfTicketBuy < 0)
            {
                try
                {
                    Console.WriteLine($"Enter number of tickets purchase for {colour}:");
                    numOfTicketBuy = int.Parse(Console.ReadLine());

                    if (numOfTicketBuy < 0)
                    {
                        Console.WriteLine("Number of ticket purchase cannot be negative. Please enter a non-negative number.");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input. Please enter a valid non-negative number.");
                }
            }

            return numOfTicketBuy;
        }
    }
}
