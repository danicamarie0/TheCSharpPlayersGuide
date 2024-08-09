namespace theReplicatorOfToDs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I will ask you to input 5 numbers below, please proceed...");
            int[] original = new int[5];

            for (int item = 0; item < 5; item++)
            {
                Console.Write("Please Enter a number here: ");
                int number = Convert.ToInt32(Console.ReadLine());
                original[item] = number;
            }

            int[] copy = new int[5];

            for (int index = 0; index < 5; index++)
                copy[index] = original[index];

            for (int index = 0; index < 5; index++)
                Console.WriteLine($"{original[index]} and {copy[index]}");
        }
    }
}
