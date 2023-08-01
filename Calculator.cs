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
            Console.WriteLine();
            Console.WriteLine("Hello! I'm here to make calculations for you!");
            Console.WriteLine();
            Console.WriteLine("Input the first number:");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input the second number:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What do you want to do? **Type in only the letter between the brackets and press enter.**");
            Console.WriteLine("[A]dd numbers");
            Console.WriteLine("[S]ubstract numbers");
            Console.WriteLine("[M]ultiply numbers");
            Console.WriteLine("[D]ivide numbers");
            var userInput = Console.ReadLine();

            if (userInput == "a" || userInput == "A")
            {
                var sum = num1 + num2;
                printSolution(num1, num2, sum, "+");
            }
            else if (userInput == "s" || userInput == "S")
            {
                var sub = num1 - num2;
                printSolution(num1, num2, sub, "-");
            }
            else if (userInput == "m" || userInput == "M")
            {
                var mult = num1 * num2;
                printSolution(num1, num2, mult, "*");
            }
            else if (userInput == "d" || userInput == "D")
            {
                var mult = num1 / num2;
                printSolution(num1, num2, mult, "/");
            }
            else
            {
                Console.WriteLine("Invalid choice!");
            }


            void printSolution(int num1, int num2, int result, string operatorChosen)
            {
                Console.WriteLine($"{num1} {operatorChosen} {num2} = {result} ");

            }
        }
    }
}
