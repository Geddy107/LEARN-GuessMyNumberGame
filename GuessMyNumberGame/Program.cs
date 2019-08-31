using System;

namespace GuessMyNumberGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your number range.");
            Console.WriteLine("----------------------------------");

            Console.WriteLine("Enter minimum value");
            int min = int.Parse(Console.ReadLine()); //takes user min range

            Console.WriteLine("Enter maximum value");
            int max = int.Parse(Console.ReadLine()); //takes users max range


            Console.WriteLine($"Please guess a number between {min} and {max}");
            int usrInp = int.Parse(Console.ReadLine()); // takes user's guessed number

            Console.Clear();
            int avg = min - 1; //set to avoid errors on users end

            while (avg != usrInp)
            {
                avg = (max + min) / 2; //halves the users rang and continues to do so until the users number is reached.

                Console.WriteLine($"Your number is: {usrInp}");
                Console.WriteLine($"The Computer guesses: {avg}");
                Console.WriteLine("------------------------------");

                Console.WriteLine("Is your number lower or higher? \n please select: \n 'H' for higher \n 'L' for lower ");
                if (avg == usrInp)
                {
                    Console.Clear();
                    Console.WriteLine($"I guessed it your number is {usrInp}");
                    break;
                }
                ConsoleKey input = Console.ReadKey().Key;


                if (input == ConsoleKey.L)
                {
                    max = avg;
                }

                else if (input == ConsoleKey.H)
                {
                    min = avg;
                }

            }

        }









    }
}
