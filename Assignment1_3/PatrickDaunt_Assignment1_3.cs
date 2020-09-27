/*
 * Author: Patrick D
 * Date Created: 27 Sep 2020
 * Descrption: User has to guess a number between 1 - 10
 */

using System;
using static System.Console;

namespace Assignment1_3
{
    class Assignment1_3
    {
        static void Main(string[] args)
        {
            Assignment1_3 a13 = new Assignment1_3(); // Instantiate class object
            a13.randomNumGame(); // Call a class method
        }

        public void randomNumGame()
        {
            Random randomNumberGenerator = new Random(); // Instantiate random number generator object
            int randomNumber = randomNumberGenerator.Next(1, 11); // Set limits for random number generation

            int guessCount = 0; // Declare method variables
            int i = 0;
            int userGuess;

            while (i < 1)
            {
                Console.WriteLine("Guess what the random number is (1-10): "); // Guess statement
                userGuess = Int32.Parse(ReadLine());
                
                if (userGuess > randomNumber)
                {
                    guessCount += 1;
                    Console.WriteLine("Your guess is too high");
                }
                else if (userGuess < randomNumber)
                {
                    guessCount += 1;
                    Console.WriteLine("Your guess is too low");
                }
                else if (userGuess == randomNumber)
                {
                    guessCount += 1;
                    Console.WriteLine("You got it! It took {0} attempt(s)", guessCount);
                    ++i; // increase i variable to exit while loop
                }
            }                           
        }
    }
}
