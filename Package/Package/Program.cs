using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Insurance
{
    class Program
    {
        static void Main()
        {
        Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
        Console.WriteLine("Please enter the package weight: ");
        string weight = Console.ReadLine();
            

        if (Convert.ToInt32(weight) < 50) {
                Console.WriteLine("Please enter the package width: ");
                string width = Console.ReadLine();
                Console.WriteLine("Please enter the height: ");
                string height = Console.ReadLine();
                Console.WriteLine("Please enter the length: ");
                string length = Console.ReadLine();
                 if (Convert.ToInt32(width) + Convert.ToInt32(height) + Convert.ToInt32(length) < 50  ) {
                    double shipping = (((Convert.ToInt32(width) * Convert.ToInt32(height) *Convert.ToInt32(length)) * Convert.ToInt32(weight)) / 100);
                    Console.WriteLine("Your estimated total for shipping this package is: " + shipping);
                 }
                 else {
                    Console.WriteLine("Package too big to be shipped via Package Express");}
        else {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            }
        
            }

            Console.ReadLine();





          
        }
    }
}