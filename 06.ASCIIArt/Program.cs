using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int L = int.Parse(Console.ReadLine());
        int H = int.Parse(Console.ReadLine());
        var T = Console.ReadLine().ToUpper().ToCharArray();

        for (int i = 0; i < H; i++)
        {
            string ROW = Console.ReadLine();

            var rowResults = T
                .Select(x => char.IsLetter(x) ? (x - 'A') * L : 26 * L)
                .Select(x => ROW.Substring(x, L));
            Console.WriteLine(string.Join(string.Empty, rowResults));
        }
    }
}