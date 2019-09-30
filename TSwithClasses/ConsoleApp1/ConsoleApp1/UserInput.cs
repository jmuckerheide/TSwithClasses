using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class UserInput
    {
        string ticket = "ticketData.csv";
        string userChoice;
        public string UserChoice
        {
            get { return userChoice; }
            set { userChoice = value; }
        }
        public void Choice1()
        {
            if (userChoice == "1")
            {
                if (File.Exists(ticket))
                {
                    StreamReader sr = new StreamReader(ticket);
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        // convert string to array
                        string[] arrayConverter = line.Split(',');
                        Console.WriteLine("Recipient Name: " + arrayConverter);
                    }
                }
            }
        }
        public void Choice2()
        {
            if (userChoice == "2")
            {
                // create ticket
                StreamWriter sw = new StreamWriter(ticket);
                for (int i = 0; i < 10; i++)
                {
                    //new ticket file
                    ticket = "ticketData" + i + ".csv";
                    //display ticket name
                    Console.WriteLine("Ticket Name: " + ticket);
                    //name of ticket recipient 
                    Console.WriteLine("Enter name of the ticket recipient");
                    string ticketRecipient = Console.ReadLine();
                    //generate ticketID
                    int ticketID = i;
                    Console.WriteLine("Ticket ID: " + ticketID);
                }
                sw.Close();
            }
        }
    }
}
