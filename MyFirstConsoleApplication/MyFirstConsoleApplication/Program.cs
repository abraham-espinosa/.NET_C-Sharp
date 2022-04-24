using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            GetUserNameAndLocation();
            ChristmasCountdown();
            GlazerApp.RunExample();
            Console.WriteLine("Press any key to continue.");
            while (Console.ReadKey().Key != ConsoleKey.Enter) { }

        }
        private static void GetUserNameAndLocation()
        {
            Person person = new Person();
            Console.WriteLine("What is your name?");
            person.name = Console.ReadLine();
            Console.WriteLine($"Hi {person.name}! Where are you from?");
            person.location = Console.ReadLine();
            Console.WriteLine($"I have never been to {person.location}. I bet it is nice. Press any key to continue...");
            Console.WriteLine("Press any key to continue.");
            while (Console.ReadKey().Key != ConsoleKey.Enter) { }
        }

        private static void ChristmasCountdown()
        {
            DateTime date = DateTime.Now;
            Console.WriteLine($"Today's date is: {date.ToString("MMMM dd yyyy")}");
            DateTime christmasDate = new DateTime(2022, 12, 25);
            double daysForChristmas = (christmasDate - date).TotalDays;
            Console.WriteLine($"There are {daysForChristmas:.} days until Christmas!");
            Console.WriteLine("Press any key to continue.");
            while (Console.ReadKey().Key != ConsoleKey.Enter) { }
        }
    }
}

