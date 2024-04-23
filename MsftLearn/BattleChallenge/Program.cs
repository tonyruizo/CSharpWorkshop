namespace BattleChallenge;

class Program
{
    static void Main(string[] args)
    {
        Random randomNum = new Random();

        int heroHealth = 10;
        int monsterHealth = 10;

        while (heroHealth > 0 && monsterHealth > 0)
        {
            int attackValue = randomNum.Next(1, 11);
            System.Console.WriteLine($"(Hero attacked!) ***{attackValue} Damage***");
            monsterHealth -= attackValue;
            System.Console.WriteLine("");
            System.Console.WriteLine($"Monster was damaged and lost {attackValue} health and now has {monsterHealth} health.");
            System.Console.WriteLine("");

            if (monsterHealth <= 0)
            {
                continue;
            }

            attackValue = randomNum.Next(1, 11);
            System.Console.WriteLine($"(Monster attacked!) ***{attackValue} Damage***");
            heroHealth -= attackValue;
            System.Console.WriteLine("");
            System.Console.WriteLine($"Hero was damaged and lost {attackValue} health and now has {heroHealth} health.");
            System.Console.WriteLine("");


        }
        System.Console.WriteLine(heroHealth > monsterHealth ? "Hero wins!" : "Monster won.");

    }
}
