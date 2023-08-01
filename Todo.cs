using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpWorkshop
{
    internal class Todo
    {
        public static void Run()
        {
            // INTRO
            Console.WriteLine();
            Console.WriteLine("Welcome to your TODO App");
            Console.WriteLine();
            Console.WriteLine("**For navigation, only type in the first letter of the options.\nFor help, type in 'help'.");
            Console.WriteLine();
            // Directions
            Console.WriteLine("What would you like to do today?");
            Console.WriteLine("[S]ee all TODOs");
            Console.WriteLine("[A]dd a TODO");
            Console.WriteLine("[R]emove a TODO:");
            Console.WriteLine("[E]xit");

            // GRAB WHAT HAS BEEN TYPED
            var userChoice = Console.ReadLine();

            // IF NOT EMPTY, MAKE IT INTO UPPERCASE
            if (userChoice != null)
            {
                userChoice = userChoice.ToUpper();

                // SWITCH STATEMENT
                switch (userChoice)
                {
                    case "S":
                        PrintSelectedOption("See all TODOs");
                        break;
                    // ADDING EXTRA CASE, IF NEEDED (ALREADY CONVERTED TO UPPER WITH .TOUPPER()
                    //case "a":
                    case "A":
                        PrintSelectedOption("Add a TODO");
                        break;
                    case "R":
                        PrintSelectedOption("Remove a TODO");
                        break;
                    case "E":
                        PrintSelectedOption("Exit");
                        Console.WriteLine("Goodbye.");
                        break;
                    case "HELP":
                        Console.WriteLine();
                        Console.WriteLine("/help\nTips: When prompted a question or options, simply type the letter in between the brackets and press enter.");
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }
            else
            {
                Console.WriteLine("No input, try again.");
            }


            // METHOD
            void PrintSelectedOption(string input)
            {
                Console.WriteLine($"You have Selected option: '{input}'");

            }
        }
    }
}
