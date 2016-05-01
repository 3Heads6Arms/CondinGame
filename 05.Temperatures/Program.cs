using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine()); // the number of temperatures to analyse
        var temps = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        var minTemp = temps
            .Select(int.Parse)
            .OrderBy(Math.Abs)
            .ThenByDescending(x => x)
            .FirstOrDefault();

        Console.WriteLine(minTemp);
    }
}
