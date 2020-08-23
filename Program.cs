using System;

namespace NumberGueesingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfGuess = 0;
            int maxNumberOfGuess = 5;
            int guessLeft;
            int userGuess;
            Random guess = new Random ();
            int computerNumber = guess.Next(1, 10);
            string userName = "";
//          Console.WriteLine(computerNumber);
            Console.Write("Please enter your name: ");
            userName = Console.ReadLine();
            Console.WriteLine("Welcome to guessing game "+ userName);
            
            while ( numberOfGuess < maxNumberOfGuess)
            {
                Console.Write("Enter guess between 1 and 10: ");
                userGuess = Convert.ToInt32(Console.ReadLine());
                numberOfGuess ++;
                guessLeft = maxNumberOfGuess - numberOfGuess;
                if (userGuess < computerNumber)
                {
                    Console.WriteLine(userName +" your guess is too low!\n" );
                    Console.WriteLine(userName +" you have " + guessLeft +" more tries left!");
                }
                else if (userGuess > computerNumber)
                {
                    Console.WriteLine(userName +" your guess is too high!\n" );
                    Console.WriteLine(userName +" you have " + guessLeft +" more tries left!");
                }
                else if (userGuess == computerNumber)
                {
                    Console.WriteLine(userName +" good job It took you "+ numberOfGuess + " tries to guess the number.");
                    break;
                }
            
            if (userGuess != computerNumber)
            {
                Console.WriteLine(userName +" You Lost the game! The number was  " + computerNumber);
            }
            }
        }
    }
} 
