namespace ProcessStringArray;

class Program
{
    static void Main(string[] args)
    {
        // My string array
        string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };

        // Declare integer variable to hold location of period
        int periodLocation = 0;
        string myString;

        for (var i = 0; i < myStrings.Length; i++)
        {
            // Each element assigned to myString per loop
            myString = myStrings[i];
            // First period location
            periodLocation = myString.IndexOf('.');

            string mySentence;

            while (periodLocation != -1)
            {
                // Sentence is any characters before the period
                mySentence = myString.Remove(periodLocation);

                myString = myString.Substring(periodLocation + 1);

                // Remove white space
                myString = myString.Trim();

                // Update the index location
                periodLocation = myString.IndexOf(".");

                Console.WriteLine(mySentence);
            }

            mySentence = myString.Trim();
            System.Console.WriteLine(mySentence);
        }


    }
}
