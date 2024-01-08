﻿using System;
class program 
{
    static void Main(string[] args)
    {
        try { // we put what we want to try in our program here 
        Console.WriteLine("Pick a number.");
        int numberone = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Pick a second number");
        int numbertwo =  Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Dividing the two ...");
        int numberthree = numberone/numbertwo;
        Console.WriteLine(numberone + "divided by " + numbertwo +"equals" +numberthree);
        Console.ReadLine(); //pauses it so we can see our output
        }
        catch (FormatException ex)
        {
            Console.WriteLine(ex.Message);
            //Could also do Console.WriteLine("Please write a whole number");
        }
        catch(DivideByZeroException ex) 
        {
            Console.WriteLine("Please do not divide by zero");
        }

        catch(Exception ex) //This can be used as a general catch all.

        {
            Console.WriteLine(ex.Message);
        }

        finally
        {
             Console.ReadLine();
        }
       

    }

}

//Perform these actions and create a console app that includes the following:
//Create a list of integers. Ask the user for a number to divide each number in the list by. Write a loop that takes each integer in the list, divides it by the number the user entered, and displays the result to the screen.
//Run the code, entering in non-zero numbers as the user. Look at the displayed results.
//Run the code again, entering in zero as the number to divide by. Note any error messages you get.
//Run the code once again, entering in a string as the number to divide by. Note any error messages you get.
//Now put the loop in a try/catch block. Below and outside of the try/catch block, make the program print a message to the display to let you know the program has emerged from the try/catch block and continued on with program execution. In the catch block, display the error message to the screen. Then try various combinations of user input: valid numbers, zero and a string. Ensure the proper error messages display on the screen, and that the code after the try/catch block gets executed.
//Add comments to each line or block of your code to explain what it does exactly, so that another developer could read and understand your code.
//Upload your code to GitHub and submit the link below: