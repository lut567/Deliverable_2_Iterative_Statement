/*
 * 
 * coder: Shane Luttmann
 * 9/9/19
 * Deliverable 2 - Iterative Statement
 * 
 */

using System;

namespace Deliverable_2_Iterative_Statement
{
    class Program
    {
        static void Main(string[] args)
        {


            // Use of a Try Catch Statement
            try
            {
                // Prompt for user input
                Console.Write("Enter a number between 1 and 100: ");
                // Parse input to int
                int number = int.Parse(Console.ReadLine());

                // If statement to determin if user input is between 1 and 100
                if (number > 0 && number <= 100)
                {
                    // loopNum used to loop the while loop while keeping number intact
                    int loopNum = number;

                    // While loop that will loop through what the user has input. While loop will loop till loopNum reaches 0
                    while (loopNum > 0)
                    {
                        // writeline to display output
                        Console.WriteLine("You have entered: " + number + " This is the current integer value in the loop: " + loopNum);
                        // decrease loopNet down by one to prevent infinite loop
                        loopNum--;
                    }
                }
                else
                {
                    // If user inputs a number greater than 100 or less than 1 this text will display for the user
                    Console.WriteLine("**Enter a number between 1 and 100**");
                }

            }
            // catch statement if any errors occure from above code
            catch (Exception ex)
            {
                // Error message
                Console.WriteLine(ex.Message);
            }
        }
    }
}
