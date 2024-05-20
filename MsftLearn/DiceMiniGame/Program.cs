using System.Xml.XPath;

namespace DiceMiniGame;

class Program
{
    static void Main(string[] args)
    {
        // Select a target from random roll between 1-5.
        // user must roll six-diced dice.
        // To win, the player must roll a number > target
        // Ask player to play again.

        Random roll = new Random();
        bool playAgain = true;


        Console.WriteLine("Welcome to Dice Game! Let's get started!");

        while (playAgain)
        {
            Console.WriteLine("\nLets roll the target..");
            int targetNumber = RollDice();

            Console.WriteLine($"Target number: {targetNumber}");

            System.Console.WriteLine("\nLets roll your dice...");
            int userRoll = RollDice();

            System.Console.WriteLine($"Your Roll: {userRoll}");

            // Check win or loose
            Console.WriteLine(WinOrLose(targetNumber, userRoll));

            // Ask to play again
            playAgain = ShouldPlay();

        }

        // Method to determine if win or loose
        string WinOrLose(int target, int userRoll)
        {
            return (userRoll > target) ? "You won!" : "You loose! :(";
        }

        // Method to determine to play again or not.
        bool ShouldPlay()
        {
            Console.WriteLine("Would you like to play again? (Y/N)");
            string userAnswer = Console.ReadLine()!;

            if (userAnswer == "Y".ToLower())
            {
                return true;
            }

            return false;
        }

        // Method to get random roll
        int RollDice()
        {
            return roll.Next(1, 7);
        }

    }
}
