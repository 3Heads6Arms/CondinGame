using System;

class Program
{
    static void Main(string[] args)
    {
        int road = int.Parse(Console.ReadLine()); // the length of the road before the gap.
        int gap = int.Parse(Console.ReadLine()); // the length of the gap.
        int platform = int.Parse(Console.ReadLine()); // the length of the landing platform.

        // game loop
        while (true)
        {
            int speed = int.Parse(Console.ReadLine()); // the motorbike's speed.
            int coordX = int.Parse(Console.ReadLine()); // the position on the road of the motorbike.

            // Write an action using Console.WriteLine()
            // To debug: Console.Error.WriteLine("Debug messages...");

            string action = "WAIT";
            if (speed <= gap)
            {
                action = "SPEED";
            }
            else if (coordX + speed > road)
            {
                action = "JUMP";
            }

            if (speed > gap + 1 || coordX >= road + gap)
            {
                action = "SLOW";
            }

            // A single line containing one of 4 keywords: SPEED, SLOW, JUMP, WAIT.
            Console.WriteLine(action);
        }
    }
}

