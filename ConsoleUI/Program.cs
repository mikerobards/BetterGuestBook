using System;
using System.Collections.Generic;
using GuestBookLibrary.Models;


// Capture the info about each guest (assumption at least one guest and unknown maximum)
// Info to capture: First name, Last name, message to the host
// Once done capturing, loop thru each guest and print their info

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Better Guest Book!");

            List<GuestModel> guests = new List<GuestModel>();
            // using a List because you can keep adding to it

            // loop through each guest

            string moreGuestsComing = "";

            do // run the code at least once
            {
                GuestModel guest = new();

                Console.Write("What is your first name: ");
                guest.FirstName = Console.ReadLine();

                Console.Write("What is your last name: ");
                guest.LastName = Console.ReadLine();

                Console.Write("What is your message to the host: ");
                guest.MessageToHost = Console.ReadLine();

                Console.Write("Are more guests coming? (y/n) ");
                moreGuestsComing = Console.ReadLine();

                guests.Add(guest);

                Console.Clear();
            } while (moreGuestsComing.ToLower() == "y");

            foreach (GuestModel guest in guests)
            {
                Console.WriteLine(guest.GuestInfo);
            }

        }
    }
}
