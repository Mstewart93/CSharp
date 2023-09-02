using System; 


namespace myConsoleProject.cs 
/*Name Space is an added layer of organization. It is listed above
 class, this helps us remember where items are stored. For now it is the 
same as program.*/
{
    class Program
    {
        static void Main()
        /*static void Main(string[] args) is a function named main that tkes on the argument args.
         Reminder Subprogram will need parameters or data, and the acutal data is 
        an argument.*/
        {
            Console.WriteLine("What is your name?");//will display
            string name = Console.ReadLine(); //takes input
            Console.WriteLine("Hello, " + name + "!"); //Will insert name vsrible into string
            Console.Read(); // prevents console auto closing, makes it read then display



        }
    }
}
