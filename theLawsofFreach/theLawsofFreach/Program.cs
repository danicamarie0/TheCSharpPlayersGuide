namespace theLawsofFreach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };

            int currentMinimum = int.MaxValue;  

            foreach (int value in array)
            {
                if (value < currentMinimum)
                    currentMinimum = value;
            }

            Console.WriteLine(currentMinimum);


            int total = 0;

            foreach (int value in array)
                total += value;

            float average = (float)total / array.Length;

            Console.WriteLine(average);
        }
    }
}
