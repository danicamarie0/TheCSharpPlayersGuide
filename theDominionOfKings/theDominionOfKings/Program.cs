namespace theDominionOfKings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Please input how many provinces do you have: ");
            string numberOfProvinceText = Console.ReadLine();
            var numberOfProvince = Convert.ToInt32(numberOfProvinceText);
            numberOfProvince *= 6;
            var totalPointsOfProvince = numberOfProvince;
            Console.WriteLine($" Congrats! Your total points for Province is {totalPointsOfProvince} !");


            Console.WriteLine(" Next please input how many estates do you have? ");
            string numberOfEstateText = Console.ReadLine();
            var numberOfEstate = Convert.ToInt32(numberOfEstateText);
            numberOfEstate *= 1;
            var totalPointsOfEstate = numberOfEstate;
            Console.WriteLine($" Congrats! Your total points for your Estates is {totalPointsOfEstate} !");

            Console.WriteLine(" Then please, input how many duchy do you have: ");
            string numberOfDuchyText = Console.ReadLine();
            var numberOfDuchy = Convert.ToInt32(numberOfDuchyText);
            numberOfDuchy *= 3;
            var totalPointsOfDuchy = numberOfDuchy; 
            Console.WriteLine($" Congrats! Your total points for your Duchy is {totalPointsOfDuchy} !");

            var totalPointsOfKingdom = totalPointsOfProvince + totalPointsOfEstate + totalPointsOfDuchy;
            Console.WriteLine($" Yay! Your total points for your kingdom is {totalPointsOfKingdom} ! ");


        }
    }
}
