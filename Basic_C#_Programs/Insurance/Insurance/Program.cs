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
            int UserAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Have you ever had a DUI? Please enter Yes or No.");
            bool DUI = Console.ReadLine().ToLower() == "yes";
            Console.WriteLine("How many speeding tickets do you have?");
            string ticket = Console.ReadLine().ToLower();
            int SpeedingTicket = Convert.ToInt32(ticket);
            bool qualified = ((UserAge>15) && !DUI && (SpeedingTicket <=3));
            Console.WriteLine(qualified);
        }
    }
}
