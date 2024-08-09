namespace theVariableShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            int c = 30;
            Console.WriteLine(" I picked up " + ( c + a + b ) + " Roses " );

            short numberOfPeonies = 6000;
            Console.WriteLine(" On the second field I picked up " + numberOfPeonies + " of Peonies. ");

            byte aGroupOfTulip = 5;
            Console.WriteLine(" On the third field I picked up " + aGroupOfTulip + " of Tulips. ");

            long numberOfDaises = 3000000000000000;
            Console.WriteLine(" On the fourth field I saw atleast " + numberOfDaises + " Daises.");

            sbyte numberOfLotus = -100;
            Console.WriteLine(" On the way to the fifth field, the river was missing " + numberOfLotus + "Lotus from the heavy rain.");

            ushort numberOfOrchid = 35;
            Console.WriteLine(" Next to the river there's plenty of trees with each containing, " + numberOfOrchid + " Orchid ");

            ulong numberOfSunflowers = 60000000000000000;
            ulong numberOfSunflowersPicked = 10;
            Console.WriteLine(" On the fifth field I saw " + numberOfSunflowers + " Sunflowers and I picked up " + numberOfSunflowersPicked);

            uint numberOfIris = 4000000000;
            uint numberOfIrisPicked = 10;
            Console.WriteLine(" On the sixth field I saw " + numberOfIris + " Iris and I picked up " + numberOfIrisPicked);

            char aExclamation = '!';
            Console.WriteLine(" Out of all the flowers which one if your favorite? ");
            string flowerName = Console.ReadLine();
            Console.WriteLine(" Oh " + flowerName + " is a wonderful flower " + aExclamation);

            double earningsFromSunflowers = 79.9;
            Console.WriteLine(" We earned " + earningsFromSunflowers + " from Sunflowers! " );

            float earningsFromIris = 39.9f;
            Console.WriteLine(" We earned " + earningsFromIris + " from Iris! ");

            decimal totalEarningsFromFlowers = 100000.90m;
            Console.WriteLine(" The total number of earnings we have is " + totalEarningsFromFlowers );

            bool weEarned = true;
            Console.WriteLine(" Did we earned more than 50000? ");
            Console.WriteLine(weEarned);







        }
    }
}
