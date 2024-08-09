using System.ComponentModel.Design;

namespace repairingTheClocktower
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Clocktower Repairer";

            Console.Write("Please input the time:");
            var time = Convert.ToInt32(Console.ReadLine());

            if (time % 2 == 0)
            {
                Console.WriteLine("Tick");
            }
            else
            {
                Console.WriteLine("Tock");
            }
        }
    }
}
