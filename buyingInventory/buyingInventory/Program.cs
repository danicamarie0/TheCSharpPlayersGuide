using System.Diagnostics;

namespace buyingInventory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Buying Inventory";
            Console.WriteLine("The following items are available:");
            Console.WriteLine("1 = Rope");
            Console.WriteLine("2 = Torches");
            Console.WriteLine("3 = Climbing Equipment");
            Console.WriteLine("4 = Clean Water");
            Console.WriteLine("5 = Machete");
            Console.WriteLine("6 = Canoe");
            Console.WriteLine("7 = Food Supplies");
            Console.WriteLine("What number do you want to see the price of?");

            var choice = Convert.ToInt32(Console.ReadLine());

            //switch (choice)
            //{
            //    case 1:
            //        Console.WriteLine("Ropes cost 10 gold");
            //        break;
            //    case 2:
            //        Console.WriteLine("Torches cost 15 gold");
            //        break;
            //    case 3:
            //        Console.WriteLine("Climbing Equipment cost 25 gold");
            //        break;
            //    case 4:
            //        Console.WriteLine("Clean Water cost 1 gold");
            //        break;
            //    case 5:
            //        Console.WriteLine("Machetes cost 20 gold");
            //        break;
            //    case 6:
            //        Console.WriteLine("Canoes cost 200");
            //        break;
            //    case 7:
            //        Console.WriteLine("Food Supplies cost 1 gold");
            //        break;
            //}





            //var inventoryNumber = Convert.ToInt32(Console.ReadLine());

            //string item = inventoryNumber switch
            //{
            //    1 => "Rope",
            //    2 => "Torches",
            //    3 => "Climbing Equipment",
            //    4 => "Clean Water",
            //    5 => "Machete",
            //    6 => "Canoe",
            //    7 => "Food Supplies",
            //    _ => throw new NotImplementedException()
            //};

            //var price = item switch
            //{
            //    "Rope" => 10,
            //    "Torches" => 15,
            //    "Climbing Equipment" => 25,
            //    "Clean Water" => 1,
            //    "Machete" => 20,
            //    "Canoe" => 200,
            //    "Food Supplies" => 1
            //};
            //Console.Write("What is your name? ");
            //string name = Console.ReadLine();

            //if (name == "Dani") price /= 2;
            //Console.WriteLine($"{item} costs {price} gold.");











            string item;
            int price;

            switch (choice)
            {
                case 1:
                    item = "Ropes";
                    price = 10;
                    break;
                case 2:
                    item = "Torches";
                    price = 15;
                    break;
                case 3:
                    item = "Climbing Equipment";
                    price = 25;
                    break;
                case 4:
                    item = "Clean Water";
                    price = 1;
                    break;
                case 5:
                    item = "Machete";
                    price = 20;
                    break;
                case 6:
                    item = "Canoe";
                    price = 200;
                    break;
                case 7:
                    item = "Food Supplies";
                    price = 1;
                    break;
                default:
                    item = "Not Found";
                    price = 0;
                    break;

            }
            Console.Write("What is your name? ");
            string name = Console.ReadLine();

            if (name == "Dani") price /= 2;
            Console.WriteLine($"{item} costs {price} gold.");



        }
    }
}
