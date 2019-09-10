using System;

namespace Deliverable_2_Iterative_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter a number between 1 and 100: ");
                int number = int.Parse(Console.ReadLine());

                if (number > 0 && number <= 100)
                {
                    int loopNum = number;

                    while (loopNum > 0)
                    {
                        Console.WriteLine("You have entered: " + number + " This is the current integer value in the loop: " + loopNum);
                        loopNum--;
                    }
                }
                else
                {
                    Console.WriteLine("**Enter a number between 1 and 100**");
                }

            }
            catch
            {
                Console.WriteLine("ERROR!");
            }



        }
    }
}
