using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousIncome
{
    class Program
    {
        static void Main()
        {
            //Begin with printing the welcoming message
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1:"); 
            Console.WriteLine("Hourly Rate");
            string rate1 = Console.ReadLine(); //Takes input for person 1 hourly rate
            Double Hrate1 = Convert.ToDouble(rate1);//Converst to something we can do math with
            Console.WriteLine("Hours Worked Per Week: ");
            string week1 = Console.ReadLine();//Takes hours per week input
            int Hweek1 = Convert.ToInt32(week1);//Converst so we cn do mth
            Console.WriteLine("Person 2:");
            Console.WriteLine("Hourly Rate");
            string rate2 = Console.ReadLine();//Takes input for person 2 hourly rate
            Double Hrate2 = Convert.ToDouble(rate2);//Converst to something we can do math with
            Console.WriteLine("Hours Worked Per Week: ");
            string week2 = Console.ReadLine();//Takes hours per week input
            int Hweek2 = Convert.ToInt32(week2);//Converst so we cn do mth
            double AnnualSalary1 = Hrate1 * Hweek1; //Creats the sallary to compare by
            double AnnualSalary2 = Hrate2 * Hweek2;
            Console.WriteLine("Annual salary of Person 1:\n" + AnnualSalary1); //Prints the salary of both
            Console.WriteLine("Annual salary of Person 2:\n" + AnnualSalary2);
            Console.WriteLine("Does Person 1 make more money than Person 2?"); 
            bool turefalse = AnnualSalary1 > AnnualSalary2; //Makes the coprison
            Console.WriteLine(turefalse); //prints the comprison
            Console.Read(); //keeps open till we close it
        }
    }
}
