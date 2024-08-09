namespace HuntingManticore
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var playerOne = GetPlayerName("Player 1");
            var playerTwo = GetPlayerName("Player 2");

            var cityHealth = 15;
            var manticoreHealth = 10;
            var round = 1;

            var range = AskNumberInRange($"{playerOne}, how far away from the city do you want to station the Manticore?", 0, 100);
            Console.Clear();

            Console.WriteLine($"{playerTwo}, now is your turn!");

            while (cityHealth > 0 && manticoreHealth > 0)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("-----------------------------------------");
                DisplayStatus(round, cityHealth, manticoreHealth);

                var damage = DamageForRound(round);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"The cannon is expected to deal {damage} damage this round");

                Console.ForegroundColor = ConsoleColor.White;
                var targetRange = AskNumber("Please Enter desired cannon range:");

                Console.ForegroundColor = ConsoleColor.Magenta;
                DisplayOverOrUnder(targetRange, range);

                if (targetRange == range) manticoreHealth -= damage;
                if (manticoreHealth > 0) cityHealth--;
                round++;
            }

            bool won = cityHealth > 0;
            DisplayWinOrLose(won);
        }

        private static string? GetPlayerName(string id)
        {
              Console.WriteLine(id + ", please input your name:");
               return Console.ReadLine();
        }

        static void DisplayWinOrLose(bool won)
        {
            if (won)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("CONGRATS! The Manticorfe has been destroyed! city of Consolas has been saved!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("OH NO... The city has been destroyed. The Manticore and the Uncoded One have won");
            }
        }

        static void DisplayOverOrUnder(int targetRange, int range)
        {
            Console.Write("That round ");
            if (targetRange < range)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("FELL SHORT");
            }
            else if (targetRange > range)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("OVERSHOT");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("DIRECT HIT!");
            }
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(" of the target");
        }

        static void DisplayStatus(int round, int cityHealth, int manticoreHealth) =>
            Console.WriteLine($"STATUS: Round: {round} City: {cityHealth}/ 15 Manticore: {manticoreHealth}/10");

        static int DamageForRound(int roundNumber)
        {
            if (roundNumber % 5 == 0 && roundNumber % 3 == 0)
                return 10; //Electric and Fire Combined
            else if (roundNumber % 5 == 0)
                return 3; //Electric
            else if (roundNumber % 3 == 0)
                return 3; //Fire
            return 1; // Normal 
        }

        static int AskNumber(string text)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write(text + " ");
            var number = Convert.ToInt32(Console.ReadLine());
            return number;
        }

        static int AskNumberInRange(string text, int min, int max)
        {
            while (true)
            {
                var number = AskNumber(text);
                if (number >= min && number < max)
                    return number;
            }
        }
    }
}
