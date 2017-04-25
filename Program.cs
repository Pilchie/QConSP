using System;
using static System.Console;

class Program
{
    static void Main(string[] args)
    {
        var numbers = new object[]
        {
            0b1, 0b10, 0b100, 0b1000, 0b1_0000, 0b10_0000,
            0b1, 0b10,
            new object[] { 0b100, 0b1000 },
            null,
            0b1_0000, 0b10_0000,
        };

        var (sum, count) = Tally(numbers);
        WriteLine($"The count is {sum}, and the sum is {count}.");
    }

    private static (int sum, int count) Tally(object[] numbers)
    {
        var r = (s: 0, c: 0);

        void Add(int s, int c) { r.s += s; r.c += c; }

        foreach (var v in numbers)
        {
            switch (v)
            {
                case int i:
                    Add(i, 1);
                    break;
                case object[] nested when nested.Length > 0:
                    var t = Tally(nested);
                    Add(t.sum, t.count);
                    break;
                case null:
                    break;
            }
        }

        return r;
    }
}
