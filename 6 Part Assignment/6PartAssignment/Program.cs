using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _6partassignment
{
    class Program
    {
         Main()
        {
            // Assignment part one
            string []str1;
            str1 = ["Dogs","Chickens","Cats","Ducks","Cows"];
            Console.WriteLine("Please enter your favorite animal bellow:  ");
            string useranimal = Console.ReadLine();
            for (int i = 0; i < str1.Length; i++)
{
                str1[i] = str1[i] + useranimal;
}
            for (int i in str1; i++)
            {Console.WriteLine(str1 + useranimal)};





            //Assignment Part 2 
           
        //x = 1;
        //while (x == 1);
        //Console.WriteLine("What is your name?");
        //y = Console.ReadLine();
        //Console.WriteLine()"Hello! Welcome";
        //Since x will always equal 1 this will run constantly we need to change it to one that has an end
     
        while (int x = 5;,x > 0, x--){
            Console.WriteLine("Please Enter Your name ");
            Console.ReadLine(); 
            Console.WriteLine("Welcome!");
        }
        
       

        //Assignment part 3
        
        //A loop where the comparison that’s used to determine whether to continue iterating the loop is a “<” operator.
        //Add another loop where the comparison that’s used to determine whether to continue iterating the loop is a “<=” operator.
        for (int i = 0; i < 10; i++)
{
            Console.WriteLine("Hello, this should post 9 times :)");
}       
        while (int i = 1; i <= 10; i++)
            {Console.WriteLine("This should post 10 times however")};

        //Assignment Part 4
        
        
        //A list of strings where each item in the list is unique.
        string []str2;
        str2 = ['mouse','horse','leopard','zebra','orangatang']
        

        for (int i in str2; i++)
            {Console.WriteLine("Let's see if your favorite animal is in the list. Please enter your favorite animal:   ");
            string userinput = Console.ReadLine().ToLower;
            bool alreadyexists = str2.Contains(userinput)};
                if (alreadyexists = true):
                    {Console.WriteLine("");

                    }
                else
                {
                    
                }
                    
                
            );

        


        //A loop that iterates through the list and then displays the index of the list item that contains matching text on the screen.

        //Add code to check if the user put in text that isn't on the list and, if they did, tell the user their input is not on the list. 

        //Add code that stops the loop from executing once a match has been found.

        

       

        //Assignment Part 5
       // Add the following to your console app and perform these actions:
        //A list of strings that has at least two identical strings in the list. Ask the user to select text to search for in the list.
        //Create a loop that iterates through the list and then displays the indices of the items matching the user-selected text. Ensure to remove any break statements that may prevent your code from returning multiple matches.
        //Add code to the loop to check if the user put in text that isn't on the list and, if they did, tells the user their input is not on the list. (You do not need to provide any additional chances for the user to enter text.)


        Console.WriteLine();

        //Assignment Part 6
        //Add the following to your console app and perform these actions:
        //Create a list of strings that has at least two identical strings in the list.
        //Create a foreach loop that evaluates each item in the list, and displays a message showing the string and whether or not it has already appeared in the list. For example, if you had a list of letters: {“A”, “B”, “C”, “D”, “C”}, you could have the following print to the screen:
        //A - this item is unique
        //B - this item is unique
        //C - this item is unique
        //D - this item is unique
        //C - this item is a duplicate
        //Add comments to each line or block of your code to explain what it does exactly, so that another developer could read and understand your code.
        //Upload all the code you wrote during every step of this assignment to your GitHub account and submit the link in the space below:

        Console.WriteLine();
        }
    }
}
