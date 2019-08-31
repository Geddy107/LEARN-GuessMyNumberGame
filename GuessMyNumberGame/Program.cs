using System;

namespace GuessMyNumberGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What game would you like to play?");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("1. Have the computer try to guess your number.");
            Console.WriteLine("2. You try to guess the computer's number.");

            int gameSelect = Console.Read();

            switch (gameSelect)
            {
                case 1:
                    Console.WriteLine("Please enter your number range.");
                    Console.WriteLine("----------------------------------");

                    Console.WriteLine("Enter minimum value");
                    int min = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter maximum value");
                    int max = int.Parse(Console.ReadLine());


                    Console.WriteLine($"Please guess a number between {min} and {max}");
                    int usrInp = int.Parse(Console.ReadLine());

                    Console.Clear();
                    int avg = min - 1;

                    while (avg != usrInp)
                    {
                        avg = (max + min) / 2;

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
                    break;

                case 2:


                    break;


                default:
                    break;
            }






        }








    }
}
