using Microsoft.VisualBasic;
using System.Reflection;
using System.Threading;

namespace CSharpWorkshop
{
    public class Program
    {
        // My entry point "Main()" to my console application
        static void Main(string[] args)
        {
            // Check if any command-line argument is provided
            if (args.Length > 0)
            {
                // Convert the argument to lowercase to ensure comparison
                switch (args[0].ToLower())
                {
                    // if "calculator is matched, will execute Run() method in Calculator Class
                    case "calculator":
                        Calculator.Run();
                        break;
                    case "todo":
                        Todo.Run();
                        break;
                    case "factorialcal":
                        FactorialCal.Run();
                        break;
                    case "notespad": // I test random code in this file.
                        Notespad.Run();
                        break;
                    default: Console.WriteLine("Invalid Exercise file, please check the name and try again.");
                        break;
                }
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Please try again, but enter the exercise file name you wish to run. Type: dotnet run 'file name' (do not use quotes or spaces) then press enter.");
                Console.WriteLine();
                // Delay the next message 3.5 seconds
                Thread.Sleep(3500);

                // Calls method and assigns the returned array of strings to the variable "fileNames"
                string[] fileNames = GetAvailableCases();

                Console.WriteLine("The available file names to run are:");
                Console.WriteLine();

                // Loop through fileNames array and display each index
                foreach (string file in fileNames)
                {
                    Console.WriteLine(file);
                }
                Console.WriteLine();
            }
        }

        // GetAvailableCases Method that returns an array of strings
        static string[] GetAvailableCases()
        {
            // Use Reflection to inspect the methods in other classes
            Assembly assembly = Assembly.GetExecutingAssembly();
            Type[] types = assembly.GetTypes();

            // Define a list to store the available case names
            System.Collections.Generic.List<string> caseNames = new System.Collections.Generic.List<string>();

            foreach (Type type in types)
            {
                // Check if the type is a class and not the Program class itself
                if (type.IsClass && type.Name != "Program")
                {
                    // Check if the class has a method named "Run"
                    MethodInfo? methodInfo = type.GetMethod("Run", BindingFlags.Static | BindingFlags.Public);
                    if (methodInfo != null)
                    {
                        // Add the class name (case name) to the list of available cases
                        caseNames.Add(type.Name.ToLower());
                    }
                }
            }

            // Convert the list to an array and return it
            return caseNames.ToArray();
        }
    }
}

