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
        private static List<GuestModel> guests = new List<GuestModel>();
        // using a List because you can keep adding to it
        // moved variable outside of methods for scope

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Better Guest Book!");

            // loop through each guest

            GetGuestInfomation();

            PrintGuestInformation();

        }

        private static void PrintGuestInformation()
        {
            foreach (GuestModel guest in guests)
            {
                Console.WriteLine(guest.GuestInfo);
            }
        }

        private static void GetGuestInfomation()
        {
            string moreGuestsComing = "";

            do // run the code at least once
            {
                GuestModel guest = new();

                guest.FirstName = GetInfoFromConsole("What is your first name: ");
                guest.LastName = GetInfoFromConsole("What is your last name: ");
                guest.MessageToHost = GetInfoFromConsole("What is your message to the host: ");
                moreGuestsComing = GetInfoFromConsole("Are more guests coming? (y/n) ");

                guests.Add(guest);

                Console.Clear();
            } while (moreGuestsComing.ToLower() == "y");

        }

        private static string GetInfoFromConsole(string message)
        {
            string output = "";

            Console.Write(message);
            output = Console.ReadLine();

            return output;
        }
    }
}
