using System;

namespace In_Class_Example___Highest_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            // Collect User Input
            string xs = Console.ReadLine();
            string ys = Console.ReadLine();
            string zs = Console.ReadLine();

            // Convert stings to integers
            int x = Convert.ToInt32(xs);
            int y = Convert.ToInt32(ys);
            int z = Convert.ToInt32(zs);

            // Determine highest value
            if (x > y)
            {
                if (x > z)
                {
                    Console.WriteLine(x);
                }
                else
                {
                    Console.WriteLine(z);
                }
            }
            else if (y > z)
                Console.WriteLine(y);
            else
                Console.WriteLine(z);
        }
    }
}
