using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketData
{
    class Program: UserInput
    {
        static void Main(string[] args)
        {
            //create object of UserInput
            UserInput x = new UserInput();

            string ticket = "ticketData.csv";
            string userChoice = x.UserChoice;
            //string userChoice;
            do
            {
                // what would user like to do with ticket
                Console.WriteLine("1) Read data from ticket.");
                Console.WriteLine("2) Create ticket from data.");
                Console.WriteLine("Enter any other key to exit.");

                x.UserChoice = Console.ReadLine();
                
                if (userChoice == "1")
                {
                    x.Choice1();
                }
                else if (userChoice == "2")
                {
                    x.Choice2();
                }
            } while (userChoice == "1" || userChoice == "2");

            Exceptions e = new Exceptions();
            e.ExceptionClassExample();
        }   
    }
}
