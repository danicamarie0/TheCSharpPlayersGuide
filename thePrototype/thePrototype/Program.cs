namespace thePrototype
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("User 1, Tell me your name:");
            string user1;
            user1 = Console.ReadLine();
            Console.Write("User 2, Tell me your name:");
            string user2;
            user2 = Console.ReadLine();
            Console.WriteLine($" {user1} will challenge {user2} to guess their number ");

            int number;
            do
            {
                Console.WriteLine($" First Make sure {user2} closes their eyes! No peeking! ");
                Console.Write($" Alright {user1}, enter a number between 0 and 100 for {user2} to guess: ");
                number = Convert.ToInt32(Console.ReadLine());
            }
            while (number < 0 || number > 100);

            Console.Clear();

            Console.WriteLine($" {user2}, guess the number {user1} entered. ");

            while (true)
            {
                Console.Write(" What is your guess? ");
                int guess = Convert.ToInt32(Console.ReadLine());

                if (guess > number) Console.WriteLine($" Woah! {guess} is too high. ");
                else if (guess < number) Console.WriteLine($" Yikes! {guess} is too low. ");
                else break;
            }

            Console.WriteLine($" Congrats {user2}, you guessed the number! ");
        }
    }
}
