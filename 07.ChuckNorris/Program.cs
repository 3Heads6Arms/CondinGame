using System;
using System.Linq;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        var MESSAGE = Console.ReadLine();

        var binary = string.Join(string.Empty, MESSAGE.Select(x => Convert.ToString(x, 2).PadLeft(7, '0')));
        var chuckNorris = Regex
            .Split(binary, @"(0+|1+)")
            .Where(x => !string.IsNullOrEmpty(x))
            .Select(x => x[0] == '1' ? "0 " + new string('0', x.Length) : "00 " + new string('0', x.Length));

        Console.WriteLine(string.Join(" ", chuckNorris));
    }
}
