using System;
using System.Collections.Generic;
using System.Linq;
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
            string useranimal = Console.ReadLine;
                for (int i = 0; i < str1.len; i++)
{
str1[i] = str1[i] + useranimal;
}
            for (string i in str1; i++)
            {Console.WriteLine(str1 + useranimal)};





            //Assignment Part 2 
           // Add the following to your console app and perform these actions: 
           //An infinite loop. Save your code. 
           //Fix the infinite loop so that it will execute properly.
        //Add comments to your code indicating how the infinite loop was fixed. 

        Console.WriteLine();

        //Assignment part 3
        //Add the following to your console app and perform these actions:
        //A loop where the comparison that’s used to determine whether to continue iterating the loop is a “<” operator.
        //Add another loop where the comparison that’s used to determine whether to continue iterating the loop is a “<=” operator.


        Console.WriteLine();

        //Assignment Part 4
        //Add the following to your console app and perform these actions:
        //A list of strings where each item in the list is unique.
        //Ask the user to input text to search for in the list.
        //A loop that iterates through the list and then displays the index of the list item that contains matching text on the screen.
        //Add code to check if the user put in text that isn't on the list and, if they did, tell the user their input is not on the list. 
        //Add code that stops the loop from executing once a match has been found.
    

        Console.WriteLine();

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
