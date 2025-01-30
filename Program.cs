/*
* Author: Sheetal Rana
* Date: 29 January 2025
* Project: Task_1
* Description:
* Calculate total money spent and average price of watching the game for Joe.
*/

using System.Net.Sockets;

namespace AssignmentTaskTwo
{
    // lets create class for Ticket
    class Ticket
    {
        private string colour;
        private int price;
        private int quantity;

        public Ticket(string Colour, int Price, int Quantity)
        {
            colour = Colour;
            price = Price;
            quantity = Quantity;
        }

        public int GetTotalCost()
        {
            return quantity * price;
        }

        public int GetQuantity()
        {
            return quantity;
        }

        public string GetColour()
        {
            return colour;
        }

        public int GetPrice()
        {
            return price;
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

        // create Enum to represent ticket colour and their prices
        /*enum TicketColour
        {
           Purple = 50,
           Green = 80,
           Blue = 100
        }*/
        internal class Program
    {
        static void Main(string[] args)
        {

            // initializing variable to store number of tickets for different colour purchase and get the correct value from function GetValidNumber
            /*int purpleTickets = GetValidNumber("Purple");
            int greenTickets = GetValidNumber("Green");
            int blueTickets = GetValidNumber("Blue");
            int totalTickets = purpleTickets + greenTickets + blueTickets;*/

            Ticket purpleTickets = new Ticket("Purple", 50, Ticket.GetValidNumber("Purple", 50));
            Ticket greenTickets = new Ticket("Green", 80, Ticket.GetValidNumber("Green", 80));
            Ticket blueTickets = new Ticket("Blue", 100, Ticket.GetValidNumber("Blue", 100));
            int totalTickets = purpleTickets.GetQuantity() + greenTickets.GetQuantity() + blueTickets.GetQuantity();

            // Calculate the total money spent on buying tickets

            //int totalSpent = (purpleTickets * (int)TicketColour.Purple) + (greenTickets * (int)TicketColour.Green) + (blueTickets * (int)TicketColour.Blue);
            int totalSpent = purpleTickets.GetTotalCost() + greenTickets.GetTotalCost() + blueTickets.GetTotalCost();

            // Calculate the average price for watching game
            double averagePrice = totalSpent / totalTickets;

            // Output the results
            Console.WriteLine("Total amount spent on all tickets: $" + totalSpent.ToString("C"));
            Console.WriteLine("Average price per game: $" + averagePrice.ToString("C"));
        }
        
    }
}
