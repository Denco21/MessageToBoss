using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BetterGuestBook;
using GuestLibrary.Models;

namespace MessageToBoss
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<GuestModel> guests = new List<GuestModel>();
            WelcomeMessage.Welcome();
            GetGuestInfo(guests);
            DisplayGuestMessage(guests);

            Console.ReadLine();
        }


        private static void GetGuestInfo(List<GuestModel> guests)
        {
            string moreGuestComing = "";
           
            do
            {
                GuestModel guest = new GuestModel();
                 
                guest.FirstName = GetInfoFromConsole("Ange ditt Namn:");
                guest.LastName = GetInfoFromConsole("Ange ditt Efternamn:");

                
                guest.Section = GetInfoFromConsoleInt("Ange ditt avdelings nummer:");
                
                guest.DayTime = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");

                guest.MessageToBoss = GetInfoFromConsole("Skriv meddelandet till din chef:");

                moreGuestComing = GetInfoFromConsole("Vill du lägga till något mer? (ja/nej)");

                guests.Add(guest);

                Console.Clear();

            } while (moreGuestComing.ToLower() == "ja");
        }

        private static void DisplayGuestMessage(List<GuestModel> guests)
        {
            foreach (GuestModel guest in guests)
                Console.WriteLine(guest.ShowGuestInfo);
        }

        private static string GetInfoFromConsole(string message)
        {

            
            string output = "";
            Console.Write(message);
            output = Console.ReadLine();
            return output;
        }

        private static int GetInfoFromConsoleInt(string message)
        {
            int output = 0;
            Console.Write(message);
            output = int.Parse(Console.ReadLine());
            return output;
        }
    }
}
