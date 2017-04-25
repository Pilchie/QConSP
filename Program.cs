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
        WriteLine($"The count is {t.sum}, and the sum is {t.count}.");
    }

    private static (int sum, int count) Tally(int[] numbers)
    {
        throw new NotImplementedException();
    }
}
