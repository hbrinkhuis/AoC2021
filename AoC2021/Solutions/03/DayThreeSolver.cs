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
        var mostOccurring = new int[lineLength];

        foreach (var line in Lines)
        {
            foreach (var (i, digit) in line.ToCharArray().Select((c, i) => (i, c)))
            {
                switch (digit)
                {
                    case '1':
                        mostOccurring[i]++;
                        break;
                    case '0':
                        mostOccurring[i]--;
                        break;
                }
            }
        }

        var counts = mostOccurring.Select(c => c > 1);
        var gammaRate = uint.MinValue;
        var epsilonRate = uint.MinValue;

        foreach (var (i, c) in counts.Reverse().Select((c, i) => (i, c)))
        {
            var mask = (uint)1 << i;
            if (c)
                gammaRate |= mask;
            else
                epsilonRate |= mask;
        }

        return (gammaRate * epsilonRate).ToString();
    }

    public string SolvePartTwo()
    {
        char OxygenMatcher(int val) => val >= 0 ? '1' : '0';
        char Co2Matcher(int val) => val >= 0 ? '0' : '1';
        var oxygenGeneratorValue = MatchLinesRecursive(Lines.ToArray(), OxygenMatcher);
        var co2ScrubberValue = MatchLinesRecursive(Lines.ToArray(), Co2Matcher);
        var oxygenGenerator = Convert.ToInt32(oxygenGeneratorValue[0], 2);
        var co2Scrubber = Convert.ToInt32(co2ScrubberValue[0], 2);
        return $"{oxygenGenerator * co2Scrubber}";
    }

    private static string[] MatchLinesRecursive(string[] remainingReport, Func<int, char> matcher, int characterPosition = 0)
    {
        var counter = 0;
        foreach (var line in remainingReport)
        {
            switch (line[characterPosition])
            {
                case '0':
                    counter--;
                    break;
                case '1':
                    counter++;
                    break;
            }
        }

        var matchChar = matcher(counter); 
        var matches = remainingReport.Where(c => c[characterPosition] == matchChar).ToArray();

        return matches.Length > 1 ? MatchLinesRecursive(matches, matcher, ++characterPosition) : matches;
    }
    
    public int Day => 3;
}