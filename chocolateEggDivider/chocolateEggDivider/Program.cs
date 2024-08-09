namespace chocolateEggDivider
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Hello, How many chocolate eggs have you gathered today? ");
            string gatheredEggsText = Console.ReadLine();
            var gatheredEggs = Convert.ToInt32(gatheredEggsText);

            var equalPartsOfEggs = gatheredEggs / 4;
            var remainderOfEggs = equalPartsOfEggs % 4;
            Console.WriteLine($"That's Amazing! each four sisters should receive {equalPartsOfEggs} and {remainderOfEggs} should be fed to their duckbear ");
        }
    }
}
