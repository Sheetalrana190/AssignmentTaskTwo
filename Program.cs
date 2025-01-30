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
            int PurpleTicketPrice = 50;
            int GreenTicketPrice = 80;
            int BlueTicketPrice = 100;
            // initializing variable to store number of tickets for different colour purchase and get the correct value from function GetValidNumber
            int PurpleTickets = GetValidNumber("Purple");
            int GreenTickets = GetValidNumber("Green");
            int BlueTickets = GetValidNumber("Blue");


        }
        // function to validate user input for number of tickets for different colour
        static int GetValidNumber(string colour)
        {
            int NumOfTicketBuy = -1;
            while (NumOfTicketBuy < 0)
            {
                try
                {
                    Console.WriteLine($"Enter number of trips to {colour}:");
                    NumOfTicketBuy = int.Parse(Console.ReadLine());

                    if (NumOfTicketBuy < 0)
                    {
                        Console.WriteLine("Number of trips cannot be negative. Please enter a non-negative number.");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input. Please enter a valid non-negative number.");
                }
            }

            return NumOfTicketBuy;
        }
    }
}
