using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpWorkshop
{
    internal class FactorialCal
    {
        public static void Run()
        {
            Console.WriteLine("Let's Find the Factorial of a Number!");
            Console.WriteLine("***Factorial of a number, is the result of multiplying all integers from 1 to your chosen number");
            Console.WriteLine("Example: 5! = 1 * 2 * 3 * 4 * 5 = 120");
            Console.WriteLine();
            Thread.Sleep(3000);

            bool playAgain = true;

            while (playAgain)
            {
                Console.WriteLine("Enter a number");
                int userInputInt;
                string userInput = Console.ReadLine();
                if (int.TryParse(userInput, out userInputInt))
                {
                    var answer = Factorial(userInputInt);

                    Console.WriteLine();
                    Console.WriteLine($"The Factorial number of {userInputInt} is {answer}");
                    Console.WriteLine();

                    playAgain = askToTryAgain();
                } 
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                }
                             
            }

            Console.WriteLine("Goodbye!");

        }

        // Method for calculation
        public static int Factorial(int number)
        {
            var result = 1;
            for (int i = 1; i <= number; i++)
            {
                result *= i;
            }
            return result;
        }

        // Method to try again
        public static bool askToTryAgain()
        {
            Console.WriteLine("Would you like to try another number? (y/n)");
            string response = Console.ReadLine().Trim().ToLower();

            return response == "yes" || response == "y";
            
        }
    }
}
