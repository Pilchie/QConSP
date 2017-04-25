using System;
using static System.Console;

class Program
{
    static void Main(string[] args)
    {
        var numbers = new int[]
        {
            0b1, 0b10, 0b100, 0b1000, 0b1_0000, 0b10_0000,
        };

        var t = Tally(numbers);
        WriteLine($"The count is {t.Item1}, and the sum is {t.Item2}.");
    }

    private static (int, int) Tally(int[] numbers)
    {
        throw new NotImplementedException();
    }
}
