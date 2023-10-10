using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insurance
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("How old are you?");
            string Age = Console.ReadLine();
            int UserAge = Convert.ToInt32(Age);
            Console.WriteLine("Have you ever had a DUI? Please enter Yes or No.");
            bool DUI = Console.ReadLine().ToLower() == "yes";
            Console.WriteLine("How many speeding tickets do you have?");
            string ticket = Console.ReadLine().ToLower();
            int SpeedingTicket = Convert.ToInt32(ticket);
            bool qualified = ((UserAge>15) && !DUI && (SpeedingTicketicket <=3));
            Console.WriteLine(qualified);
            Console.Readline();
        }
    }
}
