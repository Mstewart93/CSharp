using System;
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

