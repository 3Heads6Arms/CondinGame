using System;

class Program
{
    static void Main(string[] args)
    {
        // game loop
        while (true)
        {
            int highestSoFar = 0;
            int mountToShoot = 0;
            for (int i = 0; i < 8; i++)
            {
                int mountainH = int.Parse(Console.ReadLine()); // represents the height of one mountain, from 9 to 0.

                if (highestSoFar < mountainH)
                {
                    highestSoFar = mountainH;
                    mountToShoot = i;
                }
            }

            // Write an action using Console.WriteLine()
            // To debug: Console.Error.WriteLine("Debug messages...");
             
            Console.WriteLine(mountToShoot); // The number of the mountain to fire on.
        }
    }
}
