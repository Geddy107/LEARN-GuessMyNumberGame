using System;

namespace GuessMyNumberGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int gameSelect = 0;
            while (gameSelect != 1 || gameSelect != 2)
            {
                Console.WriteLine("What game would you like to play?");
                Console.WriteLine("----------------------------------");
                Console.WriteLine("1. Have the computer try to guess your number.");
                Console.WriteLine("2. You try to guess the computer's number.");

                gameSelect = int.Parse(Console.ReadLine());
                Console.Clear();


            }


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
                    int mini = 0;
                    int maxi = 0;
                    Console.WriteLine("Please enter the range of numbers to guess from");
                    Console.WriteLine("----------------------------------");

                    Console.WriteLine("Enter minimum value");
                    mini = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter maximum value");
                    maxi = int.Parse(Console.ReadLine());

                    Random Rand = new Random();
                    int computerNumber = Rand.Next(mini, maxi);

                    Console.WriteLine($"The computer has selected a number try to guess");

                    usrInp = 0;
                    Console.Clear();
                    

                    while (computerNumber != usrInp)
                    {
                        Console.WriteLine($"Guess the number.");
                        Console.WriteLine("------------------------------");
                        usrInp = int.Parse(Console.ReadLine());

                        if (computerNumber > usrInp)
                        {
                            Console.WriteLine("You are low");
                        }
                        
                        if (computerNumber < usrInp)
                        {
                            Console.WriteLine("You are high");
                        }

                        else if (computerNumber == usrInp)
                        {
                            Console.WriteLine("CONGRATS YOU GUESSED IT!");
                        }


                    }
                    break;


                default:

                    Console.WriteLine("Sorry you have entered an incorrect number. Please try again.");
                    break;
            }






        }








    }
}
