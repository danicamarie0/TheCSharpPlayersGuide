﻿namespace theMagicCannon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int number = 1; number <= 100; number++)
            {
                if (number % 5 == 0 && number % 3 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine($"{number}: Electric and Fire");
                }
                else if (number % 5 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"{number}: Fire");
                }
                else if (number % 3 == 0)
                {
                    Console.ForegroundColor= ConsoleColor.Yellow;
                    Console.WriteLine($"{number}: Electric");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine($"{number}: Normal");
                }
                }
            }
        }
    }

