using System.Collections.Immutable;
using System.Reflection;

namespace AoC2021.Solutions._03;

public class DayThreeSolver : AbstractSolver, ISolver
{
    public DayThreeSolver(IEnumerable<string> input) : base(input)
    {
    }

    public string SolvePartOne()
    {
        // assuming equal length lines
        var lineLength = Lines[0].Length;
        var counts = new int[lineLength];

        foreach (var line in Lines)
        {
            foreach (var (i,digit) in line.ToCharArray().Select((c, i) => (i, c)))
            {
                switch (digit)
                {
                    case '1':
                        counts[i]++;
                        break;
                    case '0':
                        counts[i]--;
                        break;
                }
            }
        }
        var gammaRate = uint.MinValue;
        var epsilonRate = uint.MinValue;

        foreach (var (i, c) in counts.Reverse().Select((c, i) => (i, c)))
        {
            var mask = (uint)1 << i;
            if (c <= 0)
                epsilonRate |= mask;
            else
                gammaRate |= mask;
        }

        return (gammaRate * epsilonRate).ToString();
    }

    public string SolvePartTwo()
    {
        return string.Empty;
    }

    public int Day => 3;
}