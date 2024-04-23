namespace IntegerInputValidationChallenge;

class Program
{
    static void Main(string[] args)
    {

        // Prompt user to enter an integer
        Console.WriteLine("Please enter an integer between 5 and 10: ");
        string? userInput = Console.ReadLine();

        bool isNum = int.TryParse(userInput, out int inputNum);

        // Checking if input is empty
        while (!isNum || inputNum < 5 || inputNum > 10)
        {
            if (!isNum)
            {
                System.Console.WriteLine("That is not a valid integer");
            }
            else if (inputNum < 5)
            {
                System.Console.WriteLine("Cannot be lower than 5.");
            }
            else if (inputNum > 10)
            {
                System.Console.WriteLine("Cannot be higher than 10.");
            }

            Console.WriteLine("Please enter an integer between 5 and 10: ");
            userInput = Console.ReadLine();

            isNum = int.TryParse(userInput, out inputNum);

        }

        System.Console.WriteLine($"Your input integer of {userInput} has been accepted.");


    }
}
