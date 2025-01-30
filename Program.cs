/*
* Author: Sheetal Rana
* Date: 30 January 2025
* Project: Task_1
* Description:
* Calculate total money spent and average price of watching the game for Joe.
*/

using System;

namespace AssignmentTaskTwo
{
    // Create the Triangle class with functions
    class Ticket
    {
        string colour;
        int price;
        int quantity;

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
    }
        internal class Program
    {
        static void Main(string[] args)
        {
            int purpleTicketPrice = 50;
            int greenTicketPrice = 80;
            int blueTicketPrice = 100;

            // initializing variable to store number of tickets for different colour purchase and get the correct value from function GetValidNumber
            int purpleTicketQuantity = GetValidNumber("Purple");
            int greenTicketQuantity = GetValidNumber("Green");
            int blueTicketQuantity = GetValidNumber("Blue");
            
            // Create objects and pass the values

            Ticket purpleTickets = new Ticket("Purple", purpleTicketPrice, purpleTicketQuantity);
            Ticket greenTickets = new Ticket("Green", greenTicketPrice, greenTicketQuantity);
            Ticket blueTickets = new Ticket("Blue", blueTicketPrice, blueTicketQuantity);
            // calculate the total tickets purchase of different colour
            int totalTickets = purpleTickets.GetQuantity() + greenTickets.GetQuantity() + blueTickets.GetQuantity();

            // Calculate the total money spent on buying tickets

            double totalSpent = purpleTickets.GetTotalCost() + greenTickets.GetTotalCost() + blueTickets.GetTotalCost();

            // Calculate the average price for watching game
            double averagePrice = totalSpent / totalTickets;

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
