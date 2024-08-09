namespace theWatchTower
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the coordinate of x: ");
            var x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter the coordinate of y: ");
            var y = Convert.ToInt32(Console.ReadLine());


            if (y > 0)
            {
                if (x < 0) Console.WriteLine("Watch out the enemy is on the North West!");
                if (x == 0) Console.WriteLine("Watch out the enemy is on the North!");
                if (x > 0) Console.WriteLine("Watch out the enemy is on the North East!");
            }
            if (y == 0)
            {
                if (x < 0) Console.WriteLine("Watch out the enemy is on the West!");
                if (x == 0) Console.WriteLine("The enemy is right here!");
                if (x > 0) Console.WriteLine("");
            }



            //if (x < 0 && y > 0) Console.WriteLine("Watch out the enemy is on the North West!");
            //if (x == 0 && y > 0) Console.WriteLine("Watch out the enemy is on the North!");
            //if (x > 0 && y > 0) Console.WriteLine("Watch out the enemy is on the North East!");
            //if (x < 0 && y == 0) Console.WriteLine("Watch out the enemy is on the West!");
            //if (x == 0 && y == 0) Console.WriteLine("The enemy is right here!");
            //if (x > 0 && y == 0) Console.WriteLine("Watch out the enemy is on the East!");
            //if (x < 0 && y < 0) Console.WriteLine("Watch out the enemy is on the South West!");
            //if (x == 0 && y < 0) Console.WriteLine("Watch out the enemy is on the South!");
            //if (x > 0 && y < 0) Console.WriteLine("Watch out the enemy is on the South East!");

        }
    }
}
