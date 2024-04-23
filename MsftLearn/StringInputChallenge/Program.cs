namespace StringInputChallenge;

class Program
{
    static void Main(string[] args)
    {
        bool isAuth = false;

        Console.WriteLine("Enter your role name (Administrator, Manager, or User): ");
        string? userInput = Console.ReadLine()?.Trim().ToLower();

        while (!isAuth)
        {

            if (userInput == "administrator" || userInput == "manager" || userInput == "user")
            {
                System.Console.WriteLine($"Your input value ({userInput}) has been accepted.");
                isAuth = true;
                break;
            }

            System.Console.WriteLine($"The role name you entered ({userInput}) is not valid. Enter your role name (Administrator, Manager, or User): ");
            userInput = Console.ReadLine();
        }

    }
}
