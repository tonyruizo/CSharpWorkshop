using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

            List<string> list = new List<string>();

            // GRAB WHAT HAS BEEN TYPED
            var userChoice = Console.ReadLine();

            // IF NOT EMPTY, MAKE IT INTO UPPERCASE
            if (userChoice != null)
            {
                userChoice = userChoice.ToUpper();

                if (userChoice == "S")
                {
                    foreach (string item in list)
                    {
                        Console.WriteLine(item);
                    }

                }
                else if (userChoice == "A")
                {
                    while (true)
                    {

                        Console.WriteLine("What would you like to add?");
                        var itemInput = Console.ReadLine();
                        list.Add(itemInput);
                        Console.WriteLine();
                        Console.WriteLine($"{itemInput} has been added.");
                        Console.WriteLine();
                        Console.WriteLine($"Current list contains: {list}");
                        Console.WriteLine();

                        Console.WriteLine("Would you like to another task? (Y/N)");
                        var toRepeat = Console.ReadLine();
                        if (toRepeat.ToUpper() == "N")
                        {
                            //Console.WriteLine($"Total of {}");
                            Thread.Sleep(3000);
                            break;
                        }

                    }
                }
                else if (userChoice == "R")
                {

                }
                else if (userChoice == "E")
                {
                    Console.WriteLine("Goodbye.");
                }
                else if (userChoice == "HELP")
                {
                    Console.WriteLine();
                    Console.WriteLine("/help\nTips: When prompted a question or options, simply type the letter in between the brackets and press enter.");
                }
                else
                {
                    Console.WriteLine("No input, try again. Goodbye.");
                }


            }

        }
    }
}
