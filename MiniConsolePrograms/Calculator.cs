using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpWorkshop
{
    public class Calculator
    {
        public static void Run()
        {
            bool playAgain = true;

            Console.WriteLine();
            Console.WriteLine("Hello! I'm here to make calculations for you!");
            Console.WriteLine();
            while (playAgain)
            {
                Console.WriteLine("Input the first number:");
                var num1 = Console.ReadLine();

                if (int.TryParse(num1, out int num1Int))
                {
                    Console.WriteLine("Input the second number:");
                    var num2 = Console.ReadLine();

                    if (int.TryParse(num2, out int num2Int))
                    {
                        Console.WriteLine("What do you want to do? **Type in only the letter between the brackets and press enter.**");
                        Console.WriteLine("[A]dd numbers");
                        Console.WriteLine("[S]ubstract numbers");
                        Console.WriteLine("[M]ultiply numbers");
                        Console.WriteLine("[D]ivide numbers");
                        var userInput = Console.ReadLine();

                        if (userInput == "a" || userInput == "A")
                        {
                            var sum = num1Int + num2Int;
                            printSolution(num1Int, num2Int, sum, "+");
                        }
                        else if (userInput == "s" || userInput == "S")
                        {
                            var sub = num1Int - num2Int;
                            printSolution(num1Int, num2Int, sub, "-");
                        }
                        else if (userInput == "m" || userInput == "M")
                        {
                            var mult = num1Int * num2Int;
                            printSolution(num1Int, num2Int, mult, "*");
                        }
                        else if (userInput == "d" || userInput == "D")
                        {
                            var mult = num1Int / num2Int;
                            printSolution(num1Int, num2Int, mult, "/");
                        }
                        else
                        {
                            Console.WriteLine("Invalid choice!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please type in a number.");
                    }
                }
                else
                {
                    Console.WriteLine("Please type in a number.");
                }
            }

            Console.WriteLine("Goodbye!");

            void printSolution(int num1, int num2, int result, string operatorChosen)
            {
                Console.WriteLine($"{num1} {operatorChosen} {num2} = {result} ");
                playAgain = askToTryAgain();
            }
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
