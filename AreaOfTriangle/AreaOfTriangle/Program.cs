using System;
namespace AreaOfTriangle

{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input the base of the Triangle:");
            string baseOfTriangleText = Console.ReadLine();
            int baseOfTriangle = Convert.ToInt32(baseOfTriangleText);

            Console.WriteLine("Please input the height of the Triangle:");
            string heightOfTriangleText = Console.ReadLine();
            int heightOfTriangle = Convert.ToInt32(heightOfTriangleText);

            double areaOfTriangle = (double) (baseOfTriangle * heightOfTriangle) / 2;

            Console.WriteLine("The area of the Triangle is " + areaOfTriangle);
        }
    }
}
