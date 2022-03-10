using System.Collections.Immutable;

namespace AoC2021.Solutions._01;

public class DayOneSolver : AbstractSolver, ISolver
{
    public DayOneSolver(IEnumerable<string> input) : base(input)
    {
    }
    
    public string SolvePartOne()
    {
        var counter = 0;
        var depth = int.MaxValue;
        foreach (var value in Lines.Select(int.Parse))
        {
            if (value > depth) 
                counter++;

            depth = value;
        }
        return counter.ToString();
    }

    public string SolvePartTwo()
    {
        var counter = 0;
        var slidingAverage = int.MaxValue;
        var intLines = Lines.Select(int.Parse).ToImmutableArray();
        for(var i = 0; i < intLines.Length; i++)
        {
             if(i + 2 >= Lines.Length)
                 continue;

             var avgValue = intLines[i] + intLines[i + 1] + intLines[i + 2];
             if (avgValue > slidingAverage)
                 counter++;

             slidingAverage = avgValue;
        }

        return counter.ToString();
    }

    public int Day => 1;
}