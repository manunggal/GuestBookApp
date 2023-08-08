using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuestBook
{
    public class WelcomeGuest
    {
        public static (string mainGuest, int companionNumbers, string companionNames) getGuestInfo()
        {
            // greet guest and ask the name, save the name as mainGuest, to be used for array name later
            Console.WriteLine("Hi, welcome to the party");
            Console.Write("What is your name: ");
            string mainGuest = Console.ReadLine();

            // ask companion numbers
            Console.Write("How many companions coming with you: ");
            int companionNumbers = int.Parse(Console.ReadLine());

            // ask companion names
            Console.Write("Can you provide their name also: ");
            string companionNames = Console.ReadLine();

            return (mainGuest, companionNumbers, companionNames);

        }

        // method to create guest array
        public static string[] createGuestArray(string arrayName)
        {
            string[] guestCompanionArray = arrayName.Split(',');
            foreach(string companion in guestCompanionArray)
            {
                Console.WriteLine(companion);
            }
         

            return guestCompanionArray;
        }
    }
}
