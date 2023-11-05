using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppsubmission
{
    class Program
    {
        static void Main()
        {
            // Do a boolean comparison using a while statement.
            //Do a boolean comparison using a do while statement.
            //Add comments 
             int i = 0;
            do {
                Console.Writeline("i = 0", i);
                j = 10;
                i++;
                while (j <= 10)
                {
                    Console.Writeline("j = 10", i);
                    j--;
                }
            } while (i < 5);
        }
    }
}
