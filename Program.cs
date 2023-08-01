namespace CSharpWorkshop
{
    public class Program
    {
        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                switch (args[0].ToLower())
                {
                    case "calculator":
                        Calculator.Run();
                        break;
                    case "todo":
                        Todo.Run();
                        break;
                    default: Console.WriteLine("Invalid Exercise file, please check the name and try again.");
                        break;
                }
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Please enter the exercise file name you wish to run. (Example) dotnet run 'filename' (do not use quotes) then press enter.");
            }
        }
    }
}

