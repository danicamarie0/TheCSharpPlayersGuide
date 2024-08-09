namespace theDefenseOfConsolas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "The Defense of Consolas";

            Console.Write("Please input the Target Row: ");
            var row = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please input the Target Column: ");
            var column = Convert.ToInt32(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine($"({row}, {column - 1})");
            Console.WriteLine($"({row - 1}, {column})");
            Console.WriteLine($"({row}, {column + 1})");
            Console.WriteLine($"({row + 1}, {column})");

            Console.Beep();
        }
    }
}
